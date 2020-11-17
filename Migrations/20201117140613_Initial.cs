using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServerAppFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    RecipeUrl = table.Column<string>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Cakes" },
                    { 10, "Desserts" },
                    { 8, "Sweet Dough" },
                    { 7, "Frostings, Fillings & Jams" },
                    { 6, "Brownies & Bars" },
                    { 9, "Pastry" },
                    { 4, "Pies & Tarts" },
                    { 3, "Bread" },
                    { 2, "Cookies" },
                    { 5, "Crips, Crumbles & Cobblers" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "Name" },
                values: new object[,]
                {
                    { 6, "Summer" },
                    { 1, "General" },
                    { 2, "Year End Holidays" },
                    { 3, "Spring" },
                    { 4, "Fall & Thanksgiving" },
                    { 5, "Halloween" },
                    { 7, "Valentine's Day" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "Difficulty", "Name", "RecipeUrl", "SeasonId" },
                values: new object[,]
                {
                    { 1, 1, 2, "Chocolate Cake", "https://www.noracooks.com/vegan-chocolate-cake/", 1 },
                    { 5, 2, 2, "S'more Cookies", "https://www.hotforfoodblog.com/recipes/2014/08/09/smore-cookies/", 6 },
                    { 7, 1, 2, "Zombie Brain Cupcakes", "https://www.bearplate.com/vegan-zombie-brain-cupcakes/", 5 },
                    { 15, 2, 4, "Pumpkin Roll", "https://makeitdairyfree.com/vegan-pumpkin-roll/", 4 },
                    { 4, 4, 3, "Apple Pie", "https://www.gretchensveganbakery.com/the-best-apple-pie-recipe/", 4 },
                    { 22, 4, 3, "Lemon Meringue Pie", "https://tasty.co/recipe/the-best-ever-vegan-cinnamon-rolls", 3 },
                    { 13, 8, 3, "Hot Cross Buns", "https://www.avantgardevegan.com/recipes/hot-cross-vegan-buns/", 3 },
                    { 8, 1, 2, "Strawberry Lemondade Cupcakes", "https://www.theppk.com/2020/05/strawberry-lemonade-cupcakes/", 3 },
                    { 6, 8, 3, "King Cake", "https://foodwithfeeling.com/vegan-king-cake/", 3 },
                    { 3, 1, 2, "Carrot Cake with Cream Cheese Icing", "https://lovingitvegan.com/vegan-carrot-cake-lemon-buttercream-frosting/", 3 },
                    { 16, 2, 1, "Chocolate Peppermint Crinkle Cookies", "https://www.mydarlingvegan.com/chocolate-peppermint-crinkle-cookies/", 2 },
                    { 14, 10, 3, "Aquafaba Christmas Tree Meringues", "https://projectveganbaking.com/aquafaba-christmas-tree-meringues/", 2 },
                    { 21, 6, 2, "Salted Caramel Brownie", "https://tasty.co/recipe/the-best-ever-vegan-cinnamon-rolls", 1 },
                    { 18, 8, 3, "Cinnamon Rolls", "https://tasty.co/recipe/the-best-ever-vegan-cinnamon-rolls", 1 },
                    { 17, 3, 2, "Rosemary Focaccia", "https://www.gimmesomeoven.com/rosemary-focaccia-bread/", 1 },
                    { 12, 9, 4, "French Macarons", "https://www.youtube.com/watch?v=fKGDtUruRqE&t=271s", 1 },
                    { 11, 7, 3, "Swiss Meringue Buttercream", "https://www.gretchensveganbakery.com/aquafaba-swiss-buttercream-recipe/", 1 },
                    { 10, 9, 5, "Croissants", "http://www.marystestkitchen.com/how-to-make-vegan-croissants/", 1 },
                    { 9, 2, 1, "Sugar Cookies", "https://www.noracooks.com/vegan-sugar-cookies/", 1 },
                    { 2, 2, 1, "Chocolate Chip Cookies", "https://www.noracooks.com/vegan-chocolate-chip-cookies/", 1 },
                    { 19, 1, 1, "Victoria Sponge", "https://veggiedesserts.com/vegan-victoria-sponge-recipe/", 6 },
                    { 20, 9, 4, "Pavlova", "https://projectveganbaking.com/vegan-pavlova/", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_SeasonId",
                table: "Recipes",
                column: "SeasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}
