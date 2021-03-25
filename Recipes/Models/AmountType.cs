using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class AmountType
    {

        public AmountType()
        {
           
            Ingredients = new List<Ingredient>();
        }
        public Guid AmountTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
