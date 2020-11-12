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
        public ViewResult Index(int season, int category)
        {
            // options for Seasons query
            var seasonOptions = new QueryOptions<Season>
            {
                OrderBy = s => s.SeasonId
            };

            //options for Category query 
            var categoryOptions = new QueryOptions<Category>
            {
                OrderBy = c => c.CategoryId
            };

            // options for Recipes query
            var recipeOptions = new QueryOptions<Recipe>
            {
                Includes = "Category, Season"
            };
            // order by Seasons if no filter. Otherwise, filter by season and order by time.
            if(category != 0)
            {
                recipeOptions.Where = c => c.CategoryId == category;
                recipeOptions.OrderBy = d => d.Difficulty;
            }
            if(season != 0)
            {
                recipeOptions.Where = s => s.SeasonId == season; 
                recipeOptions.OrderBy = d => d.Difficulty;
            }
            else
            {
                recipeOptions.OrderBy = c => c.CategoryId;
            }

            // execute queries
            ViewBag.Seasons = seasons.List(seasonOptions);
            ViewBag.Categories = categories.List(categoryOptions); 
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
