using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RecipesWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddRecipe()
        {
            return View();
        }
        public IActionResult RecipeList()
        {
            return View(Models.Repository.Recipes.OrderBy(r => r.RecipeName));
        }
        public IActionResult ReviewRecipe()
        {
            return View();
        }
        public IActionResult ViewRecipe(int id)
        {
            return View(Models.Repository.Recipes.Where(r => r.ID == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult SubmitForm(Models.Recipe recipe)
        {
            Models.Repository.AddRecipe(recipe);
            return View(recipe);
        }

    }
}