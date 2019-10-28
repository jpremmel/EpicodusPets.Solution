using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pets.Migrations
{
    public partial class seedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FavoriteThings = table.Column<string>(nullable: true),
                    LeastFavoriteThings = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "FavoriteThings", "Gender", "LeastFavoriteThings", "Name", "Owner", "Species" },
                values: new object[,]
                {
                    { 1, 6, "Shih-tzu mix", "Grey, lanky, fluffy, distinct underbite", "Chicken, tortellini, beach, snow, her toys, being cozy", "Female", "Grooming, vet visits, guitars, being cold, being alone", "Sylvie", "Jacqueline", "Dog" },
                    { 2, 7, "Shih-tzu", "lazy bum", "yogurt, cheese, carrots, sleep", "Female", "Grooming, vet visits, raspberries (not the food), being alone", "Bridget", "Jason", "Dog" },
                    { 3, 5, "Long-hair Domestic Feline", "Floofy McCuddlebug, Diva", "naps, snacks, being the little spoon, screaming", "Male", "Toe touches, Watching his brother get affection, Being hungry ", "Chunk", "Sofia", "Cat" },
                    { 4, 7, "Medium-hair Domestic Feline", "Lovebug, Angel, Shy", "Snuggles, Gravy, Treats, Feather", "Male", "Loud noises, Strangers, Sudden movements, Vacuum", "Toad", "Sofia", "Cat" },
                    { 5, 6, "Short-hair Domestic Feline", "A fine boi looking for his furrever girl.", "His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt", "Male", "The vacuum, being picked up, having his nails clipped", "Winston", "Mike", "Cat" },
                    { 6, 5, "German Shepard 1st Generation German-American", "A Scooby Doo kinda guy looking for his Nova.", "Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls", "Male", "Boxes, rain, baths, anything outdoors (except snow)", "Roscoe", "Jen", "Dog" },
                    { 7, 1, "Medium-hair Domestic Feline", "Mau is friendly to a fault.", "Mau enjoys taking naps and climbing house plants.", "Female", "Rain and being told what to do", "Mau", "Micah", "Cat" },
                    { 8, 12, "Dutch Shepherd", "A scary looking dog that is a true sweetheart", "Jasper loves stuffed toys, food, cheese, and water", "Male", "Rain. Loud Noises.", "Jasper", "Erin", "Dog" },
                    { 9, 4, "Australian Cattledog", "Wren is a red heeler that loves to pick on other dogs", "Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese.", "Female", "Rain and being told what to do", "Wren", "Chris", "Dog" },
                    { 10, 2, "Australian Shepherd", "Ridiculously fluffy and adorable, and knows it", "All squeeky toys.", "Female", "Limes", "Molly", "Christine", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
