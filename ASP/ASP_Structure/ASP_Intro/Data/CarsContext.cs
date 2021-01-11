using ASP_Intro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro.Data
{
    public class CarsContext : DbContext
    {
        // un DbSet représente une table en base de données
        public DbSet<Car> Cars { get; set; }

        // public DbSet<Engine> Engines { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            // ajout d'un index unique
            // builder.Entity<Engine>().HasIndex(item => item.Puissance).IsUnique();
        }








        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
            
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=DbCarsContext;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }*/

    }
}
