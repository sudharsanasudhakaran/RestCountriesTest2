using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCountriesTest.Models
{
    public class Continents
    {
        public int id { get; set; }
        public int ContinentId { get; set; }
        public string ContinentName { get; set; }
         public int CountryCode { get; set; }
    }
}
