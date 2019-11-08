using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebsite.Models
{
    public class Recipe
    {
        public static int count = 0;
        public Recipe()
        {
            count++;
        }
        public int ID { get; set; } = count;
        public string RecipeName { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
    }
}