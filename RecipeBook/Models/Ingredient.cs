using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RecipeBook.Models
{
    [Table(Name = "Ingredients")]
    public class Ingredient
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IngredientID { get; set; }
        [Column]
        public string IngredientType { get; set; }

        public Ingredient()
        {

        }
        public Ingredient(string ingredientType)
        {
            IngredientType = ingredientType;
        }
    }
}
