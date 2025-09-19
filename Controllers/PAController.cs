using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webgis.Models;

namespace webgis.Controllers
{
   
    public class PAController : Controller
    {
        [Authorize (Roles ="Manager")]
        public IActionResult PA()
            {
                return View();
            }
        public IActionResult Reglements()
        {
            // Exemple de données
            var zones = new List<Zone>
            {
                new Zone { Id = 1, Nom = "Zone A", ReglementPdf = "/pdfs/ZoneA.pdf" },
                new Zone { Id = 2, Nom = "Zone B", ReglementPdf = "/pdfs/ZoneB.pdf" },
                new Zone { Id = 3, Nom = "Zone C", ReglementPdf = "/pdfs/ZoneC.pdf" },
                new Zone { Id = 4, Nom = "Zone D", ReglementPdf = "/pdfs/ZoneD.pdf" },
                new Zone { Id = 5, Nom = "Zone E", ReglementPdf = "/pdfs/ZoneE.pdf" },
                new Zone { Id = 6, Nom = "Zone I", ReglementPdf = "/pdfs/ZoneI.pdf" },
                new Zone { Id = 7, Nom = "Zone PB", ReglementPdf = "/pdfs/ZonePB.pdf" },
                new Zone { Id = 8, Nom = "Zone PU", ReglementPdf = "/pdfs/ZonePU.pdf" },
                new Zone { Id = 9, Nom = "Zone S", ReglementPdf = "/pdfs/ZoneS.pdf" },
                new Zone { Id = 10, Nom = "Zone ZR", ReglementPdf = "/pdfs/ZoneZR.pdf" },
                new Zone { Id = 11, Nom = "Equipements", ReglementPdf = "/pdfs/EquipementsAINCHOCK.pdf" },
                new Zone { Id = 12, Nom = "Patrimoine", ReglementPdf = "/pdfs/PATRIMOINE.pdf" },
                new Zone { Id = 12, Nom = "Planche Ain Chock", ReglementPdf = "/pdfs/PlancheEnsemble.pdf" }
            };

            return View(zones);
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}