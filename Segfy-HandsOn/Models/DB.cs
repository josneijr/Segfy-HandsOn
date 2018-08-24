using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy_HandsOn.Models
{
    public class DB
    {
        public class SegurosDbContext : DbContext
        {
            public DbSet<Seguro> Seguros { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=seguros.db");
            }
        }
    }
}
