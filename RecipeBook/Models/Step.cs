using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    [Table(Name = "Steps")]
    public class Step
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int StepID { get; set; }
        [Column]
        public int RecipeID { get; set; }
        [Column]
        public string StepDesc { get; set; }

        public Step()
        {

        }
        public Step(int recipeID, string stepDesc)
        {
            RecipeID = recipeID;
            StepDesc = stepDesc;
        }

        public override string ToString()
        {
            return $"{StepDesc}";
        }
    }
}
