using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServerAppFinalProject.Migrations
{
    public partial class Season : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "SeasonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "SeasonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 1,
                column: "Name",
                value: "General");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "SeasonId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "SeasonId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 1,
                column: "Name",
                value: "Birthday");
        }
    }
}
