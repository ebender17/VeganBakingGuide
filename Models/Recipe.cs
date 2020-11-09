using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServerAppFinalProject.Models
{
    public class Recipe
    {
        //EF Core will configure the database to generate this value
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }
        public string Origin { get; set;  }
    }
}
