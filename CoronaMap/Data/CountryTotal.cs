using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaMap.Data
{
    public class CountryTotal : CountryDetails, IEnumerable
    {
        public string name { get; set; }
        public string alpha2code { get; set; }
        public string alpha3code { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }

        public CountryTotal()
        {

        }

        public CountryTotal(DataRow row) : base(row)
        {
            try
            {
                row["name"].ToString();
            }
            catch { }
            try
            {
                alpha2code = row["alpha2code"].ToString();
            }
            catch { }
            try
            {
                alpha3code = row["alpha3code"].ToString();
            }
            catch { }
            try
            {
                latitude = Convert.ToDouble(row["latitude"]);
            }
            catch { }
            try
            {
                longitude = Convert.ToDouble(row["longitude"]);
            }
            catch { }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
