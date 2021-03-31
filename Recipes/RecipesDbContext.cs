using Microsoft.EntityFrameworkCore;
using Recipes.EntityConfigurations;
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
                .ApplyConfiguration(new AmountTypeConfiguration());

            modelBuilder
                .ApplyConfiguration(new CategoryConfiguration());

            modelBuilder
                .ApplyConfiguration(new IngredientConfiguration());

            modelBuilder
                .ApplyConfiguration(new RecipeConfiguration());

            modelBuilder
                .ApplyConfiguration(new TagConfiguration());
        }
    }
}
