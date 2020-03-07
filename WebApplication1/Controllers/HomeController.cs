using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Tocame las pelotas..";
            ViewData["Message2"] = "Un poquito.";
            ViewBag.nombre = "Pedro Luis";
            ViewBag.apellido = "Jimenez Rico";
            List<string> lista = new List<string>();
            lista.Add("primero");
            lista.Add("segundo");
            lista.Add("tercero");
            lista.Add("cuarto");
            lista.Add("y final");
            lista.Add("peli0747@gmail.com");
            lista.Add("pedro.luis.jimenez.rico@gmail.com");


            return View(lista);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
