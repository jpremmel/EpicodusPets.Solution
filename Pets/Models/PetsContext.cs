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
                    new Pet { PetId = 1, Name = "Sylvie", Species = "Shih-tzu mix", Age = 6, Gender = "Female", Description = "Grey, lanky, fluffy, distinct underbite", FavoriteThings = "Chicken, tortellini, beach, snow, being cozy", LeastFavoriteThings = "Grooming, vet visits, guitars, being alone", Owner = "Jacqueline" },
                    new Pet { PetId = 2, Name = "Bridget", Species = "Shih-tzu", Age = 7, Gender = "Female", Description = "lazy bum", FavoriteThings = "yogurt, cheese, carrots, sleep", LeastFavoriteThings = "Grooming, vet visits, raspberries (not the food), being alone", Owner = "Jason" }
                );
        }
    }
}