using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCountriesTest.Models
{
    public class CountryDetails
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Capital { get; set; }
        public int ContinentId { get; set; }
    }
}
