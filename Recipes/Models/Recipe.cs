using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Tags = new List<Tag>();
            Ingredients = new List<Ingredient>();
        }
        public Guid RecipeId { get; set; } // "8D0D19A3-2161-4F84-9D2B-A8DC3A27D50F"
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public Category Category { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
