using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covid.Models
{
    public class Db:DbContext
    {
        public Db(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<CsvModel> Rows { get; set; }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CsvModel>().HasKey(x => new { x.IsoCode, x.Continent, x.Location, x.Date });
        }
    }
}
