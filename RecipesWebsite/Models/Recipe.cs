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

/*

<form action="">
    <label>
        Recipe Name:
        <input type="text" name="recipeName">
    </label>
    <label>
        Author Name:
        <input type="text" name="author">
    </label>
    <label>
        Select a Recipe Image:
        <input type="file" name="image">
    </label>
    <label>
        Date Uploaded:
        <input type="date" name="date">
    </label>
    <label>
        Type of Recipe:
        <select name="category">
            <option value="bread">Bread</option>
            <option value="dessert">Dessert</option>
            <option value="side">Side</option>
            <option value="drink">Drink</option>
            <option value="mainCourse">Main Course</option>
            <option value="pizza">Pizza</option>
            <option value="salad">Salad</option>
            <option value="snack">Snack</option>
            <option value="soup">Soup</option>
        </select>
    </label>
    <label>
        Ingredients:
        <textarea class="box" name="ingredients" rows="20">
        </textarea>
    </label>
    <label>
        Directions:
        <textarea class="box" name="directions" rows="20">
    </textarea>
    </label>
    <input type="submit" value="Submit">
</form>


    */