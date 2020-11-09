using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebServerAppFinalProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }  //PK

        [StringLength(100, ErrorMessage = "Category name may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a category name.")]
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set;  } //Navigation property
    }
}
