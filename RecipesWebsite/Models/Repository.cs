using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebsite.Models
{
    public static class Repository
    {
        private static List<Recipe> recipes = new List<Recipe>()
        {
            new Recipe
            {
                RecipeName = "Muffins",
                Author = "Hassan Shabbir",
                ImageUrl = "/images/muffin.jpg",
                Category = "dessert",
                Ingredients = "- a -b -c",
                Directions = "1) a 2) b 3) c"
            }       
        };

        public static List<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
            set
            {
                recipes = value;
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }
}
