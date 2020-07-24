using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestCountriesTest.Models;

namespace RestCountriesTest.Data
{
    public class DataSource
    {
        private CountriesDatabaseContext _db;

        public DataSource(CountriesDatabaseContext context)
        {
            _db = context;
        }
        public List<CountryDetails> countryDetail(int continentId)
        {
            return _db.CountryDetails.ToList();
        }
        public List<Continents> Continent()
        {
            return _db.Continents.ToList();
        }
        public List<Continents> Continent(int countrycode)
        {
            return _db.Continents.Where(a => a.CountryCode == countrycode).ToList();
        }

    }
}
