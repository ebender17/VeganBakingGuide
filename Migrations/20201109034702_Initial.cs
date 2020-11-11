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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "Birthday" },
                    { 2, "Year End Holidays" },
                    { 3, "Spring" },
                    { 4, "Fall & Thanksgiving" },
                    { 5, "Halloween" },
                    { 7, "Valentine's Day" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "Difficulty", "Name", "RecipeUrl", "SeasonId" },
                values: new object[] { 1, 1, 2, "Chocolate Cake", "https://www.noracooks.com/vegan-chocolate-cake/", 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "Difficulty", "Name", "RecipeUrl", "SeasonId" },
                values: new object[] { 2, 2, 1, "Chocolate Chip Cookies", "https://www.noracooks.com/vegan-chocolate-chip-cookies/", 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "Difficulty", "Name", "RecipeUrl", "SeasonId" },
                values: new object[] { 3, 1, 2, "Carrot Cake with Cream Cheese Icing", "https://lovingitvegan.com/vegan-carrot-cake-lemon-buttercream-frosting/", 3 });

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
