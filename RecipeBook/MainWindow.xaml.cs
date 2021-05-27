using RecipeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RecipeContext context = new RecipeContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\IntermediateOOP\Assessment\RecipeBook\RecipeBook\RecipeBook\RecipeDatabase.mdf;Integrated Security=True");
        List<Recipe> Recipes = new List<Recipe>();
        public MainWindow()
        {
            InitializeComponent();

            Recipes = context.GetAllRecipes();
            foreach (Recipe recipe in Recipes)
            {
                recipeList.ItemsSource = Recipes;
            }
        }

        private void recipeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Recipe selectedRecipe = (Recipe)recipeList.SelectedItem;

            //foreach(Step step in selectedRecipe.Steps)
            //{
            //    stepsList.ItemsSource = selectedRecipe.Steps;
            //}
            //Console.WriteLine($"Selected {selectedRecipe.ToString()}");
        }
    }
}
