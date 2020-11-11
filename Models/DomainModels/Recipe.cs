using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebServerAppFinalProject.Models
{
    public class Recipe
    {
        //EF Core will configure the database to generate this value
        public int RecipeId { get; set; }  //Primary Key 

        [StringLength(200, ErrorMessage = "Name may not exceed 200 characters.")]
        [Required(ErrorMessage = "Please enter a baked good name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter link to your favorite recipe.")]
        public string RecipeUrl { get; set; }

        [Required(ErrorMessage = "Please enter a difficulty for baked good.")]
        [Range(1, 5, ErrorMessage = 
            "Difficulty of baking baked good must be between 1 and 5.")]
        public int? Difficulty { get; set; }
        

        public int CategoryId { get; set; } //Foreign key property 
        public Category Category { get; set; } //Navigation property 

        //Make nullable - int?SeasonId
        public int SeasonId { get; set; } //Foreign key property 
        public Season Season { get; set; } //Navigation property 
    }
}
