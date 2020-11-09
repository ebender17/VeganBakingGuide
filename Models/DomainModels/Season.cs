using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebServerAppFinalProject.Models
{
    public class Season
    {
        public int SeasonId { get; set; }  //PK

        [StringLength(100, ErrorMessage = "Season name may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a season name.")]
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; } //Navigation property
    }
}
