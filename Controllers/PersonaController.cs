using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using figurasmvc.Models;


namespace figurasmvc.Controllers{

    public class PersonaController : Controller{

         

        public IActionResult DatosP(){
            PModel pm = new PModel();
            pm.id = 25;
            pm.name = "Alam";
            pm.lastname = "Flowers";

            return View("DatosP",pm);
        }

        public IActionResult Crear(){
            Usuarios usrs = new Usuarios();
            usrs.Id = 3;
            usrs.Name = "Alam";
            usrs.Lastname = "Flowers";

            return View("DatosP",usrs);
        }
        public IActionResult Leer(){
            PModel pm = new PModel();
            pm.id = 25;
            pm.name = "Alam";
            pm.lastname = "Flowers";

            return View("DatosP",pm);
        }
        public IActionResult Actual(){
            PModel pm = new PModel();
            pm.id = 25;
            pm.name = "Alam";
            pm.lastname = "Flowers";

            return View("DatosP",pm);
        }
        public IActionResult Borrar(){
            PModel pm = new PModel();
            pm.id = 25;
            pm.name = "Alam";
            pm.lastname = "Flowers";

            return View("DatosP",pm);
        }
    }
}