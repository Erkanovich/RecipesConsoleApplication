using System.Collections.Generic;

namespace Recipes.Models
{
    public class Category
    {
        public Category()
        {
            Recipes = new List<Recipe>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
