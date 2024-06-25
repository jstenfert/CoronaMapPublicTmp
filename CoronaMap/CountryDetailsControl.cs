using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoronaMap.Data;
using Newtonsoft.Json;
using CoronaMap.Properties;
using System.Resources;

namespace CoronaMap
{
    public partial class CountryDetailsControl : UserControl
    {
        //1,2,3
        public int ControlSize { get; set; }


        public CountryDetailsControl()
        {
            InitializeComponent();
            ControlSize = 3;
        }

        public void LoadDetails(CountryTotal totals)
        {
            if (totals.location.Length > 15)
            {
                char[] c = totals.location.ToCharArray();
                int i = totals.location.LastIndexOf(" ");
                c[i] = '\n';

                labelCountryName.Text = new string(c);
            }
            else
            {
                labelCountryName.Text = totals.location;
            }

            //labelCountryName.Text = totals.country;
            labelCritical.Text = totals.icu_patients.ToString();
            labelDeaths.Text = totals.total_deaths.ToString();
            labelInfected.Text = totals.total_cases.ToString();
            labelRecovered.Text = totals.positive_rate.ToString();
            labelLatitude.Text = totals.latitude.ToString();
            labelLongitude.Text = totals.longitude.ToString();

            labelTests.Text = totals.total_tests.ToString();
            labelPositiveTested.Text = totals.positive_rate.ToString();
            labelVaccinations.Text = totals.total_vaccinations.ToString();
            labelPopulation.Text = totals.population.ToString();
            //return;

            switch (ControlSize)
            {
                case 1:
                    {
                        this.Width = 177;
                        this.Height = 92;
                        break;
                    }
                case 2:
                    {
                        this.Width = 177;
                        this.Height = 120;
                        break;
                    }
                case 3:
                    {
                        this.Width = 200;
                        this.Height = 200;
                        break;
                    }
                default:
                    break;
            }


        }
    }
}
