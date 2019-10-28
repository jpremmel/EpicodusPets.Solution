using Microsoft.EntityFrameworkCore;

namespace EpicodusPets.Models
{
    public class PetsContext : DbContext
    {
        public PetsContext(DbContextOptions<PetsContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pet>()
                .HasData(
                    new Pet { PetId = 1, Name = "Sylvie", Species = "Shih-tzu mix", Age = 6, Gender = "Female", Description = "Grey, lanky, fluffy, distinct underbite", FavoriteThings = "Chicken, tortellini, beach, snow, her toys, being cozy", LeastFavoriteThings = "Grooming, vet visits, guitars, being cold, being alone", Owner = "Jacqueline" },
                    new Pet { PetId = 2, Name = "Bridget", Species = "Shih-tzu", Age = 7, Gender = "Female", Description = "lazy bum", FavoriteThings = "yogurt, cheese, carrots, sleep", LeastFavoriteThings = "Grooming, vet visits, raspberries (not the food), being alone", Owner = "Jason" },
                    new Pet { PetId = 3, Name = "Chunk", Species = "Long-hair Domestic Feline", Age = 5, Gender = "Male", Description = "Floofy McCuddlebug, Diva", FavoriteThings = "naps, snacks, being the little spoon, screaming", LeastFavoriteThings = "Toe touches, Watching his brother get affection, Being hungry ", Owner = "Sofia" },
                    new Pet { PetId = 4, Name = "Toad", Species = "Medium-hair Domestic Feline", Age = 7, Gender = "Male", Description = "Lovebug, Angel, Shy", FavoriteThings = "Snuggles, Gravy, Treats, Feather", LeastFavoriteThings = "Loud noises, Strangers, Sudden movements, Vacuum", Owner = "Sofia" },
                    new Pet { PetId = 5, Name = "Winston", Species = "Short-hair Domestic Feline", Age = 6, Gender = "Male", Description = "A fine boi looking for his furrever girl.", FavoriteThings = "His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt", LeastFavoriteThings = "The vacuum, being picked up, having his nails clipped", Owner = "Mike" },
                    new Pet { PetId = 6, Name = "Roscoe", Species = "German Shepard 1st Generation German-American", Age = 5, Gender = "Male", Description = "A Scooby Doo kinda guy looking for his Nova.", FavoriteThings = "Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls", LeastFavoriteThings = "Boxes, rain, baths, anything outdoors (except snow)", Owner = "Jen" },
                    new Pet { PetId = 7, Name = "Mau", Species= "Medium-hair Domestic Feline", Age = 1, Gender = "Female", Description = "Mau is friendly to a fault.", FavoriteThings = "Mau enjoys taking naps and climbing house plants.", LeastFavoriteThings = "Rain and being told what to do", Owner = "Micah"},
                    new Pet { PetId = 8, Name = "Jasper", Species= "Dutch Shepherd", Age = 12, Gender = "Male", Description = "A scary looking dog that is a true sweetheart", FavoriteThings = "Jasper loves stuffed toys, food, cheese, and water", LeastFavoriteThings = "Rain. Loud Noises.", Owner = "Erin"},
                    new Pet { PetId = 9, Name = "Wren", Species= "Australian Cattledog", Age = 4, Gender = "Female", Description = "Wren is a red heeler that loves to pick on other dogs", FavoriteThings = "Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese.", LeastFavoriteThings = "Rain and being told what to do", Owner = "Chris"},
                    new Pet { PetId = 10, Name = "Molly", Species= "Australian Shepherd", Age = 2, Gender = "Female", Description = "Ridiculously fluffy and adorable, and knows it", FavoriteThings = "All squeeky toys.", LeastFavoriteThings = "Limes", Owner = "Christine"}
                );
        }
    }
}