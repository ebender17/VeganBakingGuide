using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace WebServerAppFinalProject.Models
{
    internal class RecipeConfig : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> entity)
        {
            //Delete behavior for Category foreign key set to Restrict 
            entity.HasOne(r => r.Category)
                .WithMany(c => c.Recipes)
                .OnDelete(DeleteBehavior.Restrict);

            //Delete behavior for Season foreign key set to Restrict 
            entity.HasOne(r => r.Season)
                .WithMany(s => s.Recipes)
                .OnDelete(DeleteBehavior.Restrict); 

            entity.HasData(
                new Recipe { RecipeId = 1, Name = "Chocolate Cake", RecipeUrl = "https://www.noracooks.com/vegan-chocolate-cake/", Difficulty = 2, CategoryId = 1, SeasonId = 1  },
                new Recipe { RecipeId = 2, Name = "Chocolate Chip Cookies", RecipeUrl = "https://www.noracooks.com/vegan-chocolate-chip-cookies/", Difficulty = 1, CategoryId = 2, SeasonId = 1 },
                new Recipe { RecipeId = 3, Name = "Carrot Cake with Cream Cheese Icing", RecipeUrl = "https://lovingitvegan.com/vegan-carrot-cake-lemon-buttercream-frosting/", Difficulty = 2, CategoryId = 1, SeasonId = 3},
                new Recipe { RecipeId = 4, Name = "Apple Pie", RecipeUrl = "https://www.gretchensveganbakery.com/the-best-apple-pie-recipe/", Difficulty = 3, CategoryId = 4, SeasonId = 4 },
                new Recipe { RecipeId = 5, Name = "S'more Cookies", RecipeUrl = "https://www.hotforfoodblog.com/recipes/2014/08/09/smore-cookies/", Difficulty = 2, CategoryId = 2, SeasonId = 6 },
                new Recipe { RecipeId = 6, Name = "King Cake", RecipeUrl = "https://foodwithfeeling.com/vegan-king-cake/", Difficulty = 3, CategoryId = 8, SeasonId = 3 },
                new Recipe { RecipeId = 7, Name = "Zombie Brain Cupcakes", RecipeUrl = "https://www.bearplate.com/vegan-zombie-brain-cupcakes/", Difficulty = 2, CategoryId = 1, SeasonId = 5 },
                new Recipe { RecipeId = 8, Name = "Strawberry Lemondade Cupcakes", RecipeUrl = "https://www.theppk.com/2020/05/strawberry-lemonade-cupcakes/", Difficulty = 2, CategoryId = 1, SeasonId = 3 },
                new Recipe { RecipeId = 9, Name = "Sugar Cookies", RecipeUrl = "https://www.noracooks.com/vegan-sugar-cookies/", Difficulty = 1, CategoryId = 2, SeasonId = 1 },
                new Recipe { RecipeId = 10, Name = "Croissants", RecipeUrl = "http://www.marystestkitchen.com/how-to-make-vegan-croissants/", Difficulty = 5, CategoryId = 9, SeasonId = 1 },
                new Recipe { RecipeId = 11, Name = "Swiss Meringue Buttercream", RecipeUrl = "https://www.gretchensveganbakery.com/aquafaba-swiss-buttercream-recipe/", Difficulty = 3, CategoryId = 7, SeasonId = 1 },
                new Recipe { RecipeId = 12, Name = "French Macarons", RecipeUrl = "https://www.youtube.com/watch?v=fKGDtUruRqE&t=271s", Difficulty = 4, CategoryId = 9, SeasonId = 1 },
                new Recipe { RecipeId = 13, Name = "Hot Cross Buns", RecipeUrl = "https://www.avantgardevegan.com/recipes/hot-cross-vegan-buns/", Difficulty = 3, CategoryId = 8, SeasonId = 3 },
                new Recipe { RecipeId = 14, Name = "Aquafaba Christmas Tree Meringues", RecipeUrl = "https://projectveganbaking.com/aquafaba-christmas-tree-meringues/", Difficulty = 3, CategoryId = 10, SeasonId = 2 },
                new Recipe { RecipeId = 15, Name = "Pumpkin Roll", RecipeUrl = "https://makeitdairyfree.com/vegan-pumpkin-roll/", Difficulty = 4, CategoryId = 2, SeasonId = 4 },
                new Recipe { RecipeId = 16, Name = "Chocolate Peppermint Crinkle Cookies", RecipeUrl = "https://www.mydarlingvegan.com/chocolate-peppermint-crinkle-cookies/", Difficulty = 1, CategoryId = 2, SeasonId = 2 },
                new Recipe { RecipeId = 17, Name = "Rosemary Focaccia", RecipeUrl = "https://www.gimmesomeoven.com/rosemary-focaccia-bread/", Difficulty = 2, CategoryId = 3, SeasonId = 1 },
                new Recipe { RecipeId = 18, Name = "Cinnamon Rolls", RecipeUrl = "https://tasty.co/recipe/the-best-ever-vegan-cinnamon-rolls", Difficulty = 3, CategoryId = 8, SeasonId = 1 },
                new Recipe { RecipeId = 19, Name = "Victoria Sponge", RecipeUrl = "https://veggiedesserts.com/vegan-victoria-sponge-recipe/", Difficulty = 1, CategoryId = 1, SeasonId = 6 },
                new Recipe { RecipeId = 20, Name = "Pavlova", RecipeUrl = "https://projectveganbaking.com/vegan-pavlova/", Difficulty = 4, CategoryId = 9, SeasonId = 6 },
                new Recipe { RecipeId = 21, Name = "Salted Caramel Brownie", RecipeUrl = "https://tasty.co/recipe/the-best-ever-vegan-cinnamon-rolls", Difficulty = 2, CategoryId = 6, SeasonId = 1 },
                new Recipe { RecipeId = 22, Name = "Lemon Meringue Pie", RecipeUrl = "https://tasty.co/recipe/the-best-ever-vegan-cinnamon-rolls", Difficulty = 3, CategoryId = 4, SeasonId = 3 }

             );
        }
    }
}
