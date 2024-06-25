using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace CoronaMap.Data
{
    class WebClient
    {
        public HttpClient client { get; set; }
        private const string connectionString = "Data Source=localhost;Initial Catalog=Covid19Data;Connect Timeout=120;Integrated Security=true";

        //headers
        public string keyName { get; set; }
        public string keyValue { get; set; }
        public string hostName { get; set; }
        public string hostValue { get; set; }

        public WebClient()
        {
            client = new HttpClient();

            hostName = "x-rapidapi-host";
            hostValue = "covid-19-data.p.rapidapi.com";
            keyName = "x-rapidapi-key";
            keyValue = "381425987amshafa8dfaf378a778p1fa0b7jsn0b74c2083715";
        }

        public string GetCountries()
        {
            string result = "";
            string url = "https://covid-19-data.p.rapidapi.com/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Add(keyName, keyValue);
                client.DefaultRequestHeaders.Add(hostName, hostValue);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("help/countries?format=json").Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync();
                    result = content.Result;
                }
                else
                {
                }
            }

            return result;
        }

        public string DownloadCSV()
        {
            //string url = "https://drive.google.com/uc?export=download&id=1Fv4WEEgPxsH5EAWVCMdQooaAZOnlvMzP";
            string url = "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/latest/owid-covid-latest.csv";
            string result = "";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Add(keyName, keyValue);
                client.DefaultRequestHeaders.Add(hostName, hostValue);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync();
                    result = content.Result;
                }
                else
                {
                }
            }

            return result;
        }

        public string GetCountryNumbers(string countryCode)
        {
            string result = "";
            string url = "https://covid-19-data.p.rapidapi.com/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Add(keyName, keyValue);
                client.DefaultRequestHeaders.Add(hostName, hostValue);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("country/code?format=json&code=" + countryCode).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync();
                    result = content.Result;
                }
                else
                {
                }
            }

            return result;
        }

        public ArrayList LoadFromDB()
        {
            var conn = new SqlConnection(connectionString);
            // 
            //var command = new SqlCommand("dbo.getthedata", conn);
            var command2 = new SqlCommand("select distinct * from [dbo].[CountryDetails] left join [dbo].[Countries] on [name] COLLATE Latin1_General_CI_AS = [location]", conn);
            command2.CommandType = CommandType.Text;// StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(command2);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            ArrayList totalsList = new ArrayList();
            
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    CountryTotal totals = new CountryTotal(row);
                    totalsList.Add(totals);
                }
            }

            return totalsList;
        }

        public CountryTotal GetSingleRecord(string querystring)
        {
            var conn = new SqlConnection(connectionString);
            // 
            //var command = new SqlCommand("dbo.getthedata", conn);
            var command2 = new SqlCommand("select distinct * from [dbo].[CountryDetails] left join [dbo].[Countries] on [name] COLLATE Latin1_General_CI_AS = [location] where alpha2code = '" + querystring + "';", conn);
            command2.CommandType = CommandType.Text;// StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(command2);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            ArrayList totalsList = new ArrayList();

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    CountryTotal totals = new CountryTotal(row);
                    totalsList.Add(totals);
                }
            }

            return (CountryTotal)totalsList[0];
        }
    }
}