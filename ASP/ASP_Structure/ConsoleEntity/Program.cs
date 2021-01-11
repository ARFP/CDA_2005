using ConsoleEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleEntity
{
    class Program
    {
        /**
         * Avant de lancer le programme :
         * - Restaurer les packages NuGet
         * - Ouvrir la console Nuget
         * - Tapez les commandes : 
         *      1) Remove-Migration
         *      2) Add-Migration userDb
         *      3) Update-Database -verbose
         * 
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (ConsoleDbContext context = new ConsoleDbContext())
            {
                User user = new User() { Name = "Mike" };

                context.Users.Add(user);
                context.SaveChanges();

                Console.ReadLine();

                IEnumerable<User> users = context.Users.ToList();

                foreach(User u in users)
                {
                    Console.WriteLine(u.Id + ": " + u.Name);
                }
            }


            Console.ReadLine();
        }
    }
}
