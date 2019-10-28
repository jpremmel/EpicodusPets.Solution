using Microsoft.EntityFrameworkCore.Migrations;

namespace Pets.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "Species" },
                values: new object[] { 1, 6, "Grey, lanky, fluffy, distinct underbite", "Chicken, tortellini, beach, snow, being cozy", "Female", "Grooming, vet visits, guitars, being alone", "Sylvie", "Jacqueline", "Shih-tzu mix" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "Species" },
                values: new object[] { 2, 7, "lazy bum", "yogurt, cheese, carrots, sleep", "Female", "Grooming, vet visits, raspberries (not the food), being alone", "Bridget", "Jason", "Shih-tzu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2);
        }
    }
}
