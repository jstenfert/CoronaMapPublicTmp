using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CoronaMap.Data
{
    public partial class Country
    {
        //[Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string alpha2code { get; set; }
        public string alpha3code { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }

        public static List<Country> FromJson(string json) => JsonConvert.DeserializeObject<List<Country>>(json);
    }
}
