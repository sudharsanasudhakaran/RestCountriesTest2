using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestCountriesTest.Models
{
    public class CountriesDatabaseContext : DbContext
    {
        public CountriesDatabaseContext(DbContextOptions<CountriesDatabaseContext> options) : base (options)
        {

        }
        public DbSet<Continents> Continents { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }

    }
}
