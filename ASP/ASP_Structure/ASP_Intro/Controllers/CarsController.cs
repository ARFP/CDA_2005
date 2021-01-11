using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Intro.Models;
using ASP_Intro.Data;

namespace ASP_Intro.Controllers
{
    public class CarsController : Controller
    {
        // Contexte de base de données
        CarsContext ctx;

        public CarsController(CarsContext ctx)
        {
            this.ctx = ctx;
        }


        public IActionResult Index()
        {
            /* Car car = new Car
            { 
                Marque = "Renault", 
                Modele = "Clio"
            };

             ctx.Cars.Add(car);

            ctx.SaveChanges();
           

            ViewBag.car = car; 
            */
            // récupération des voitures enregistrées en base de données
            IEnumerable<Car> cars = ctx.Cars.ToList();

            // injection de la liste des voitures dans la vue CarsList
            return View("CarsList", cars);
        }

        public IActionResult Create()
        {

            return View();
        }


    }
}
