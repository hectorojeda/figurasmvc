using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using figurasmvc.Models;


namespace figurasmvc.Controllers{

    public class areaController : Controller{

        public IActionResult Area(){
            return View();
        }
    }
}
