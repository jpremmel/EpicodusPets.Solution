﻿// <auto-generated />
using EpicodusPets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Pets.Migrations
{
    [DbContext(typeof(PetsContext))]
    [Migration("20191028184411_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EpicodusPets.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Description");

                    b.Property<string>("FavoriteThings");

                    b.Property<string>("Gender");

                    b.Property<string>("LeastFavoriteThings");

                    b.Property<string>("Name");

                    b.Property<string>("Owner");

                    b.Property<string>("Species");

                    b.HasKey("PetId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            Age = 6,
                            Description = "Grey, lanky, fluffy, distinct underbite",
                            FavoriteThings = "Chicken, tortellini, beach, snow, her toys, being cozy",
                            Gender = "Female",
                            LeastFavoriteThings = "Grooming, vet visits, guitars, being cold, being alone",
                            Name = "Sylvie",
                            Owner = "Jacqueline",
                            Species = "Shih-tzu mix"
                        },
                        new
                        {
                            PetId = 2,
                            Age = 7,
                            Description = "lazy bum",
                            FavoriteThings = "yogurt, cheese, carrots, sleep",
                            Gender = "Female",
                            LeastFavoriteThings = "Grooming, vet visits, raspberries (not the food), being alone",
                            Name = "Bridget",
                            Owner = "Jason",
                            Species = "Shih-tzu"
                        },
                        new
                        {
                            PetId = 3,
                            Age = 5,
                            Description = "Floofy McCuddlebug, Diva",
                            FavoriteThings = "naps, snacks, being the little spoon, screaming",
                            Gender = "Male",
                            LeastFavoriteThings = "Toe touches, Watching his brother get affection, Being hungry ",
                            Name = "Chunk",
                            Owner = "Sofia",
                            Species = "Long-hair Domestic Feline"
                        },
                        new
                        {
                            PetId = 4,
                            Age = 7,
                            Description = "Lovebug, Angel, Shy",
                            FavoriteThings = "Snuggles, Gravy, Treats, Feather",
                            Gender = "Male",
                            LeastFavoriteThings = "Loud noises, Strangers, Sudden movements, Vacuum",
                            Name = "Toad",
                            Owner = "Sofia",
                            Species = "Medium-hair Domestic Feline"
                        },
                        new
                        {
                            PetId = 5,
                            Age = 6,
                            Description = "A fine boi looking for his furrever girl.",
                            FavoriteThings = "His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt",
                            Gender = "Male",
                            LeastFavoriteThings = "The vacuum, being picked up, having his nails clipped",
                            Name = "Winston",
                            Owner = "Mike",
                            Species = "Short-hair Domestic Feline"
                        },
                        new
                        {
                            PetId = 6,
                            Age = 5,
                            Description = "A Scooby Doo kinda guy looking for his Nova.",
                            FavoriteThings = "Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls",
                            Gender = "Male",
                            LeastFavoriteThings = "Boxes, rain, baths, anything outdoors (except snow)",
                            Name = "Roscoe",
                            Owner = "Jen",
                            Species = "German Shepard 1st Generation German-American"
                        },
                        new
                        {
                            PetId = 7,
                            Age = 1,
                            Description = "Mau is friendly to a fault.",
                            FavoriteThings = "Mau enjoys taking naps and climbing house plants.",
                            Gender = "Female",
                            LeastFavoriteThings = "Rain and being told what to do",
                            Name = "Mau",
                            Owner = "Micah",
                            Species = "Medium-hair Domestic Feline"
                        },
                        new
                        {
                            PetId = 8,
                            Age = 12,
                            Description = "A scary looking dog that is a true sweetheart",
                            FavoriteThings = "Jasper loves stuffed toys, food, cheese, and water",
                            Gender = "Male",
                            LeastFavoriteThings = "Rain. Loud Noises.",
                            Name = "Jasper",
                            Owner = "Erin",
                            Species = "Dutch Shepherd"
                        },
                        new
                        {
                            PetId = 9,
                            Age = 4,
                            Description = "Wren is a red heeler that loves to pick on other dogs",
                            FavoriteThings = "Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese.",
                            Gender = "Female",
                            LeastFavoriteThings = "Rain and being told what to do",
                            Name = "Wren",
                            Owner = "Chris",
                            Species = "Australian Cattledog"
                        },
                        new
                        {
                            PetId = 10,
                            Age = 2,
                            Description = "Ridiculously fluffy and adorable, and knows it",
                            FavoriteThings = "All squeeky toys.",
                            Gender = "Female",
                            LeastFavoriteThings = "Limes",
                            Name = "Molly",
                            Owner = "Christine",
                            Species = "Australian Shepherd"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
