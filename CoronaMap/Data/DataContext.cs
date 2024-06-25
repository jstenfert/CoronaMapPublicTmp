using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaMap.Data
{
    public class DataContext : DbContext
    {
        private const string connectionString = "Data Source=localhost;Integrated Security=True;Connect Timeout=30;Initial Catalog=Covid19Data;";
        //private const string connectionString = "Data Source=localhost;Initial Catalog=Covid19Data;Connect Timeout=120;Integrated Security=True;";// user id=sa;password=sqlsqlsql";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);//, sqlServerOptionsAction: sqlOptions =>
            //{
            //    sqlOptions.EnableRetryOnFailure(
            //    maxRetryCount: 10,
            //    maxRetryDelay: TimeSpan.FromSeconds(30),
            //    errorNumbersToAdd: null);
            //});
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }
    }
}
