using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_FIA35_BilderPlusPlus.Models;

namespace Web_FIA35_BilderPlusPlus.Controllers
{
    public class HomeController : Controller
    {
        // Hierin befinden sich alle Informationen zur Umgebung des Webprojekts
        // "readonly" bewirkt, dass es keine Änderungen geben kann (außer durch den Konstruktor beim Erzeugen der neuen Instanz am Anfang)
        // "private" müsste nicht extra gesetzt werden, weil alle Methoden per Standard auf "private" gesetzt sind
        private readonly IWebHostEnvironment Environment;

        public HomeController(IWebHostEnvironment _environment)  // Konstruktor ist "public", weil sonst keine Instanz von außen erzeugt wird
        {
            Environment = _environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Umgebungsinformationen zur Pfadermittlung der Bilder nutzen
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            DirectoryInfo di = new DirectoryInfo(wwwPath + "\\Bilder");
            FileInfo[] fi = di.GetFiles("*.*");
            List<FileInfo> DateiListe = new List<FileInfo>(fi);

            // Model mit Liste der Dateiinfos
            FilterSortBildList filterSortBildList = new FilterSortBildList { listDateiInfos = DateiListe, sortierTyp = "Name", sortierRichtung = "aufsteigend" };
            

            return View(filterSortBildList);
        }

        [HttpPost]
        public IActionResult Index(FilterSortBildList filterSortBildList)
        {
            // Umgebungsinformationen zur Pfadermittlung der Bilder nutzen
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            DirectoryInfo di = new DirectoryInfo(wwwPath + "\\Bilder");
            FileInfo[] fi = di.GetFiles("*.*");
            List<FileInfo> DateiListe = new List<FileInfo>(fi);            

            // Model mit Liste der Dateiinfos
            filterSortBildList.listDateiInfos = DateiListe;
            filterSortBildList.filterBildListe();

            return View(filterSortBildList);
        }
    }
}
