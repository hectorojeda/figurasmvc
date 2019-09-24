using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using figuras_mvc.Models;

namespace figuras_mvc.Controllers
{
    public class figurasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
            public String Mensage()
        {
            double volumen=0,radio=3;
            volumen =(Math.PI*Math.Pow(radio,3))*(4/3) ;
            return "El volumen de una esfera de radio "+radio+" es: "+volumen+ " cm3";
        }
        

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
