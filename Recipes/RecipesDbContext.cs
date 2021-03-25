using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes
{
    public class RecipesDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<AmountType> AmountTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RecipesDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Category>()
                .HasKey(c => c.Name);

            modelBuilder
                .Entity<Category>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder
                .Entity<Category>()
                .HasMany(c => c.Recipes)
                .WithOne(r => r.Category);

            modelBuilder
                .Entity<Recipe>()
                .Property(r => r.Description)
                .IsRequired();


        }
    }
}
