using CoronaMap.Data;
using CoronaMap.Properties;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Internal;
using System.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebClient = CoronaMap.Data.WebClient;

namespace CoronaMap
{
    public partial class MapFormFromDB : Form
    {
        public CountryDetailsControl countryDetailsControl { get; set; }

        WebClient client = new WebClient();
        ArrayList totalsList = new ArrayList();
        public MapFormFromDB()
        {
            InitializeComponent();

            //SaveToDB();

            var size = new System.Drawing.Size(gMapControl.Width, gMapControl.Height);
            gMapControl.ClientSize = size;

            LoadMap();
            totalsList = client.LoadFromDB();
            LoadCountryMarkers();
        }


        // nog steeds niet goed
        public void SaveToDB()
        {
            DataContext c = new DataContext();

            // jsonparse loop objects save to database
            String countries = client.GetCountries();
#warning doet het even niet. copy paste lijst uit database
            //List<Country> CountryList = Country.FromJson(countries);
            List<Country> CountryList = c.Countries.ToList();

            //foreach (Country country in c.Countries)
            //{
            //    c.Remove(country);
            //}
            //c.SaveChanges();

            int count = 0;

            string csv = client.DownloadCSV();
            string[] csvSplitUnfiltered = csv.Split(System.Environment.NewLine.ToCharArray());
            string[] csvSplit = csvSplitUnfiltered.Where(s => s.Trim().Length != 0).ToArray();

            DataTable table = new DataTable();
            {
                //String countrynumbers = client.GetCountryNumbers(country.alpha3code);
                //String countrynumbers = client.GetCountryNumbers(country.alpha2code).Replace('[', ' ').Replace(']', ' ');
                //CountryDetails details = CountryDetails.FromJson(countrynumbers);//.Replace("\\", "").Replace('[',' ').Replace(']',' ')); //error deserialize

                //columns
                string[] columnNames = csvSplit[0].Split(new char[] { ',' });
                for (int i = 0; i < columnNames.Count(); i++)
                {
                    table.Columns.Add(new DataColumn(columnNames[i]));
                }

                //foreach (Country country in CountryList)
                //{
                try
                {
                    for (int i = 0; i < csvSplit.Length; i++)
                    {
                        if (i > 0)
                        {
                            DataRow row = table.NewRow();

                            //rows
                            for (int j = 0; j < row.ItemArray.Length; j++)
                            {
                                string s = csvSplit[i];
                                var v = s.Split(',');
                                row[j] = v[j];
                            }

                            table.Rows.Add(row);
                            CountryDetails details = new CountryDetails(row);
                            c.CountryDetails.Add(details);
                            c.SaveChanges();
                        }
                    }

                    // c.Countries.Add(country);
                }
                catch (Exception e)
                {

                }

                if (count % 100 == 0)
                {
                    c.SaveChanges();
                }
                count++;
                //}

                int ccount = c.Countries.ToList().Count();
            }
        }

        public void LoadMap()
        {
            gMapControl.ShowCenter = false;

            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;//YandexMapProvider.Instance; //GoogleMap;
            GMap.NET.MapProviders.YandexMapProvider.Language = LanguageType.Dutch;

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //ServerOnly;

            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 15;
            gMapControl.Zoom = 5;

            GMapProvider.WebProxy = null;
            gMapControl.Position = new GMap.NET.PointLatLng(52, 5);// NL
        }

        public void HideCountryDetails()
        {
            if (countryDetailsControl != null)
            {
                try
                {
                    this.Controls.Remove(countryDetailsControl);
                }
                catch { }
            }
        }

        public void ShowCountryDetails(Point point, string countryCode, double? latitude, double? longitude)
        {
            HideCountryDetails();
            if (countryDetailsControl == null)
            {
                countryDetailsControl = new CountryDetailsControl();
            }

            this.Controls.Add(countryDetailsControl);

            WebClient wc = new WebClient();
            var totals = wc.GetSingleRecord(countryCode);

            try
            {
                var resourceManager = ResourcesNL.ResourceManager;
                ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
                DictionaryEntry entry = resourceSet.Cast<DictionaryEntry>().Where(c => c.Value.ToString() == countryCode).FirstOrDefault();
                if (entry.Key != null && entry.Key.ToString() != "")
                {
                    totals.location = entry.Key.ToString();
                }
            }
            catch { }

            countryDetailsControl.LoadDetails(totals);

            countryDetailsControl.Location = point;
            countryDetailsControl.BringToFront();
            gMapControl.Update();
        }

        public void LoadCountryMarkers()
        {
            GMapOverlay markers = new GMapOverlay("markers");

            foreach (CountryTotal countryTotal in totalsList)
            {
                if (countryTotal.latitude != null && countryTotal.longitude != null)
                {
                    PointLatLng point = new PointLatLng(countryTotal.latitude.Value, countryTotal.longitude.Value);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_small);

                    if (countryTotal.alpha2code != "")
                    {
                        string bmpText = "0";
                        if (countryTotal != null && countryTotal.total_cases != null)
                        {
                            bmpText = countryTotal.total_cases.ToString();
                        }

                        Bitmap bmp = MakeBitmapWithText(bmpText);

                        marker = new GMarkerGoogle(point, bmp);
                        marker.Tag = countryTotal.alpha2code;

                        //GMapToolTip toolTip = new GMapToolTip(marker);
                        //toolTip.Fill = new SolidBrush(Color.Gray);
                        //toolTip.Foreground = new SolidBrush(Color.Black);
                        //toolTip.Offset = new Point(0, 0);
                        //marker.ToolTip = toolTip;
                        //marker.ToolTipMode = MarkerTooltipMode.Always;
                        //marker.ToolTipText = countryTotal.confirmed.ToString();
                    }

                    markers.Markers.Add(marker);
                }
            }

            gMapControl.Overlays.Add(markers);
            gMapControl.Update();
        }

        public Bitmap MakeBitmapWithText(string text)
        {
            int width = 50;
            int height = 18;

            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(Color.White);//transparent

            if (text.Length < 5)
            {
                TextRenderer.DrawText(g, text, new Font("Arial", 12, FontStyle.Regular), new Point(0, 0), Color.Black, Color.White);
            }
            else if (text.Length < 8)
            {
                TextRenderer.DrawText(g, text, new Font("Arial", 8, FontStyle.Regular), new Point(0, 0), Color.Black, Color.White);
            }
            else
            {
                TextRenderer.DrawText(g, text, new Font("Arial", 6, FontStyle.Regular), new Point(0, 0), Color.Black, Color.White);
            }

            const int borderSize = 1;

            using (Pen border = new Pen(Color.Black /* Change it to whichever color you want. */))
            {
                g.DrawRectangle(border, 0, 0, bitmap.Width - borderSize, bitmap.Height - borderSize);
            }

            g.DrawImage(bitmap, new Point(0, 0));

            // assign the bitmap to a globally defined one
            return bitmap;
        }

        public GMapMarker HiddenMarker { get; set; }

        private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string countryCode = "";

            if (item.Tag != null)
            {
                countryCode = item.Tag.ToString();
            }

            ShowCountryDetails(e.Location, countryCode, null, null);
        }

        private void GMapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (HiddenMarker != null)
            {
                HiddenMarker.IsVisible = true;
            }

            HideCountryDetails();
        }

        private void MapForm_SizeChanged(object sender, EventArgs e)
        {
            gMapControl.Size = this.Size;
        }
    }
}