using Microsoft.EntityFrameworkCore.Migrations;

namespace Pets.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                column: "Owner",
                value: "Erin (Chris's wife)");

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "PhotoPath", "Species" },
                values: new object[] { 16, 2, "Mixed Breed Maine Coon", "Very sassy when restless but irresistably cute when sleepy", "Paper bags, boxes, being gently stroked on the nose while falling asleep", "Male", "Sylvie", "Jasper", "Will (Jacqueline's roommate)", "wwwroot/uploads/jasper-jacqueline.jpg", "Cat" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "PhotoPath", "Species" },
                values: new object[] { 17, 5, "Dachshund mix", "#1 Handsy Boy", "Wearing clothes and playing with the hose", "Male", "strangers, other dogs playing with his toys", "Levi", "Joey (Jason's brother)", "wwwroot/uploads/levi-jason.jpg", "Dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                column: "Owner",
                value: "Erin(Chris's wife)");
        }
    }
}
