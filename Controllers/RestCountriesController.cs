using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCountriesTest.Data;
using RestCountriesTest.Models;
namespace RestCountriesTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestCountriesController : ControllerBase
    {
        private DataSource dataConn;

        public RestCountriesController(CountriesDatabaseContext context)
        {
            dataConn = new DataSource(context);
        }
        
        [HttpGet("Countries")]
        public List<CountryDetails> GetCountryDetails(int continent)
        {
            return dataConn.countryDetail(continent);
        }
        [HttpGet("Continents")]
        public List<Continents> GetContinents()
        {
            return dataConn.Continent();
        }
        [HttpGet("CountriesbyContinent/{continentId}")]
        public List<CountryDetails> GetcountryDetails(int continentId)
        {
            return dataConn.countryDetail(continentId);
        }
        

    }
}
