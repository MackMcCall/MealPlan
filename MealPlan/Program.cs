using System.Xml.Linq;

namespace MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the very begginings of the Meal Planning/Recipe Storage app I'm working on.\nThis will be a very long time coming. So, new features will be getting added as I learn the skills necessary to implement them.\nThanks to all the wonderful wives, moms, and meal planners out there!\n");

            Recipe Lasagna = new Recipe("Lasagna", "Sauce", 60);
            Console.WriteLine(Lasagna.name + " " + Lasagna.ingredient + " " + Lasagna.minutes);
        }
    }
    public class Recipe
    {
        public string? name;
        public string? ingredient;
        public double? minutes;
        public Recipe(string? recipeName, string? recipeIngredient, double? recipeTime)
        {
            name = recipeName;
            ingredient = recipeIngredient;
            minutes = recipeTime;
        }
    }
}