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
        private Repository<Recipe> recipes { get; set; }
        private Repository<Category> categories { get; set; }
        private Repository<Season> seasons { get; set; }


        public HomeController(RecipeContext ctx)
        {
            recipes = new Repository<Recipe>(ctx);
            categories = new Repository<Category>(ctx);
            seasons = new Repository<Season>(ctx); 
        }
        public ViewResult Index(int id)
        {
            // options for Seasons query
            var seasonOptions = new QueryOptions<Season>
            {
                OrderBy = s => s.SeasonId
            };

            // options for Recipes query
            var recipeOptions = new QueryOptions<Recipe>
            {
                Includes = "Category, Season"
            };
            // order by Day if no filter. Otherwise, filter by day and order by time.
            if (id == 0)
            {
                recipeOptions.OrderBy = s => s.SeasonId;
            }
            else
            {
                recipeOptions.Where = s => s.SeasonId == id;
                recipeOptions.OrderBy = d => d.Difficulty;
            }

            // execute queries
            ViewBag.Seasons = seasons.List(seasonOptions);
            return View(recipes.List(recipeOptions));
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
