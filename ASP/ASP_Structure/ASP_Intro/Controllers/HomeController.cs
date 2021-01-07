using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // ViewBag : voir "Views/_ViewStart.cshtml"
            // Les données stockées dans ViewBag sont directement accessibles dans la vue
            ViewBag.WelcomeMessage = "Nous sommes heureux de vous voir.";

            // ViewData fonctionne comme ViewBag
            // ViewBag  utilise la syntaxe "objet"
            // ViewData utilise la syntaxe "Tableau/Dictionnaire"
            // Les données stockées dans ViewData sont directement accessibles dans la vue
            ViewData["OtherMessage"] = "Notre site est cool !";


            return View("AboutCompany");
        }
    }
}
