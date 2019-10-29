using Microsoft.EntityFrameworkCore.Migrations;

namespace Pets.Migrations
{
    public partial class SeedDataPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                column: "PhotoPath",
                value: "wwwroot/uploads/sylvie-jacqueline.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                column: "PhotoPath",
                value: "wwwroot/uploads/bridget-jason.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                column: "PhotoPath",
                value: "wwwroot/uploads/chunk-sofia.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                column: "PhotoPath",
                value: "wwwroot/uploads/toad-sofia.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                column: "PhotoPath",
                value: "wwwroot/uploads/winston-mike.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6,
                column: "PhotoPath",
                value: "wwwroot/uploads/roscoe-jen.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7,
                column: "PhotoPath",
                value: "wwwroot/uploads/mau-micah.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                columns: new[] { "Owner", "PhotoPath" },
                values: new object[] { "Erin(Chris's wife)", "wwwroot/uploads/jasper-chris.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9,
                column: "PhotoPath",
                value: "wwwroot/uploads/wren-chris.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10,
                column: "PhotoPath",
                value: "wwwroot/uploads/molly-christine.jpg");

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "PhotoPath", "Species" },
                values: new object[,]
                {
                    { 11, 3, "Ball Python", "Very Curious, loves to get into trouble spots.", "Climbing Branches.", "Female", "Fast Movement", "Uwa", "Erin", "wwwroot/uploads/uwa-erin.jpg", "Snake" },
                    { 12, 4, "Russian Blue Mix", "Fluffy, talkative, will steal your cheese.", "Pets and butt scratches", "Female", "Thunder and Vacuums", "Mocha", "Erin", "wwwroot/uploads/mocha-erin.jpg", "Cat" },
                    { 13, 1, "Unknown", "Dangerous", "Total domination, sleeping", "Male", "Being locked up", "Stripes", "Carrie", "wwwroot/uploads/stripes-carrie.jpg", "Cat" },
                    { 14, 3, "Coonhound/Lab", "The best dog ever", "hikes", "Female", "shower", "Kima", "Joel", "wwwroot/uploads/kima-joel.jpg", "Dog" },
                    { 15, 6, "Domestic short hair", "Has an adorable moustache", "sleeping", "Male", "screaming toddlers", "Ashford", "Anita", "wwwroot/uploads/ashford-anita.jpg", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                columns: new[] { "Owner", "PhotoPath" },
                values: new object[] { "Erin", null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10,
                column: "PhotoPath",
                value: null);
        }
    }
}
