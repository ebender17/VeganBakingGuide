using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServerAppFinalProject.Models;

namespace WebServerAppFinalProject.Controllers
{
    public class RecipeController : Controller
    {
        private Repository<Recipe> recipes { get; set; }
        private Repository<Category> catergories { get; set; }
        private Repository<Season> seasons { get; set; }

        public RecipeController(RecipeContext ctx)
        {
            recipes = new Repository<Recipe>(ctx);
            catergories = new Repository<Category>(ctx);
            seasons = new Repository<Season>(ctx); 
        }

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home"); 
        
        [HttpGet]
        public ViewResult Add()
        {
            this.LoadViewBag("Add");
            return View(); 
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            this.LoadViewBag("Edit");
            var r = this.GetRecipe(id);
            return View("Add", r);

        }

        [HttpPost]
        public IActionResult Add(Recipe r)
        {
            if (ModelState.IsValid)
            {
                if (r.RecipeId == 0)
                    recipes.Insert(r);
                else
                    recipes.Update(r);
                recipes.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                string operation = (r.RecipeId == 0) ? "Add" : "Edit";
                this.LoadViewBag(operation);
                return View();
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var opr = this.GetRecipe(id);
            return View(opr);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Recipe r)
        {
            recipes.Delete(r);
            recipes.Save();
            return RedirectToAction("Index", "Home");
        }


        // private helper methods
        private Recipe GetRecipe(int id)
        {
            var recipeOptions = new QueryOptions<Recipe>
            {
                Includes = "Category, Season",
                Where = r => r.RecipeId == id
            };
            var list = recipes.List(recipeOptions);

            // return first Class or blank Class if null
            return list.FirstOrDefault();
        }
        private void LoadViewBag(string operation)
        {
            ViewBag.Categories = catergories.List(new QueryOptions<Category>
            {
                OrderBy = c => c.CategoryId
            });
            ViewBag.Seasons = seasons.List(new QueryOptions<Season>
            {
                OrderBy = s => s.SeasonId
            });
            ViewBag.Operation = operation;
        }
    }
}
