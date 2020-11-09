using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebServerAppFinalProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Emily Bender";
            ViewBag.Item = "Chocolate Chip Cookie";
            ViewBag.Difficulty = 1; 
            return View();
        }
    }
}
