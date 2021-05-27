using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    [Database]
    class RecipeContext : DataContext
    {
        public Table<Recipe> Recipes;
        public Table<Ingredient> Ingredients;
        public Table<Quantity> Quantities;
        public Table<Step> Steps;

        public RecipeContext(string conString) : base(conString)
        {
            initData();
        }

        private void initData()
        {

            //Uncomment to refresh DB structure
            //if (!DatabaseExists()) return;
            DeleteDatabase();
            CreateDatabase();

            List<Recipe> recipes = new List<Recipe>()
            {
                new Recipe("Spaghetti", "Yummy Spaghetti", 30)
            };
            Recipes.InsertAllOnSubmit(recipes);

            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Tomato"),
                new Ingredient("Spaghetti")
            };
            Ingredients.InsertAllOnSubmit(ingredients);

            List<Quantity> quantities = new List<Quantity>()
            {
                new Quantity(1, 1, "whole", 1),
                new Quantity(1, 2, "grams", 500)
            };
            Quantities.InsertAllOnSubmit(quantities);

            List<Step> steps = new List<Step>()
            {
                new Step(1, "Boil spaghetti until al dente."),
                new Step(1, "Add tomato")
            };
            Steps.InsertAllOnSubmit(steps);
            SubmitChanges();
        }

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            var results = from r in Recipes
                          select r;

            foreach (Recipe item in results)
            {
                if (recipes.FirstOrDefault(r => r.RecipeID == item.RecipeID) != null) continue;
                recipes.Add(new Recipe(item.RecipeName, item.RecipeDescription, item.CookTime));
            }

            return recipes;
        }

    }
}
