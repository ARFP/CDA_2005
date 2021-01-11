using ConsoleEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEntity
{
    class ConsoleDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        // pour les APP ASP.NET Core
        /*public ConsoleDbContext(DbContextOptions<ConsoleDbContext> options) : base(options)
        {

        }*/

        // en mode console, on passe la config du SGBD dans OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DbUsersTests;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
