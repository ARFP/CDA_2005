using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Intro.Models;

namespace ASP_Intro.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            Car car = new Car
            { 
                VoitureId = 1,
                Marque = "Renault", 
                Modele = "Clio"
            };

            ViewBag.car = car;

            return View("CarsIndex");
        }

        public IActionResult Test()
        {

            return View();
        }
    }
}
