using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebServerAppFinalProject.Models;

namespace WebServerAppFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private RecipeContext context { get; set; }

        public HomeController(RecipeContext ctx)
        {
            context = ctx; 
        }
        public IActionResult Index()
        {
            var recipes = context.Recipes.Include(r => r.Season)
                .Include(r => r.Category)
                .OrderBy(r => r.Name).ToList();
            return View(recipes);
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Resources()
        {
            return View();
        }
    }
}
