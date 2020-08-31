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
    }
}
