using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace WebServerAppFinalProject.Models
{
    internal class RecipeConfig : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> entity)
        {
            //Add in delete behavior 
            entity.HasData(
                new Recipe { RecipeId = 1, Name = "Chocolate Cake", RecipeUrl = "https://www.noracooks.com/vegan-chocolate-cake/", Difficulty = 2, CategoryId = 1, SeasonId = 1  },
                new Recipe { RecipeId = 2, Name = "Chocolate Chip Cookies", RecipeUrl = "https://www.noracooks.com/vegan-chocolate-chip-cookies/", Difficulty = 1, CategoryId = 2, SeasonId = 1 },
                new Recipe { RecipeId = 3, Name = "Carrot Cake with Cream Cheese Icing", RecipeUrl = "https://lovingitvegan.com/vegan-carrot-cake-lemon-buttercream-frosting/", Difficulty = 2, CategoryId = 1, SeasonId = 3}

             );
        }
    }
}
