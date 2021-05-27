using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    [Table(Name = "Quantities")]
    public class Quantity
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int QuantityID { get; set; }
        [Column]
        public int RecipeID { get; set; }
        [Column]
        public int IngredientID { get; set; }
        [Column]
        public string MeasurementType { get; set; }
        [Column]
        public int Units { get; set; }

        public Quantity()
        {

        }
        public Quantity(int recipeID, int ingredientID, string measurementType, int units)
        {
            RecipeID = recipeID;
            IngredientID = ingredientID;
            MeasurementType = measurementType;
            Units = units;
        }

    }
}
