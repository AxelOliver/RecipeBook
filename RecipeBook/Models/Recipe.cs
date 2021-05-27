using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    [Table(Name = "Recipes")]
    public class Recipe
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int RecipeID { get; set; }
        [Column]
        public string RecipeName { get; set; }
        [Column]
        public string RecipeDescription { get; set; }
        [Column]
        public int CookTime { get; set; }

        public List<Quantity> quantitys{ get; set; }

        public Recipe()
        {

        }
        public Recipe(string recipeName, string recipeDescription, int cookTime)
        {
            RecipeName = recipeName;
            RecipeDescription = recipeDescription;
            CookTime = cookTime;
        }

        public override string ToString()
        {
            return RecipeName;
        }
        //private EntitySet<BookAuthor> _bookAuthors = new EntitySet<BookAuthor>();
        //[Association(Name = "FK_BookAuthors_Authors", Storage = "_bookAuthors", OtherKey = "authorId", ThisKey = "Id")]
        //private ICollection<Recipe> Recipes
        //{
        //    get { return _bookAuthors; }
        //    set { _bookAuthors.Assign(value); }
        //}

        //public ICollection<Book> Books
        //{
        //    get
        //    {
        //        return (from ba in BookAuthors select ba.Book).ToList();
        //    }
        //}
    }
}
