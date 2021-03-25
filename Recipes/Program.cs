using Recipes.Models;
using System;

namespace Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMainMenu();
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1: Add a recipe");
            Console.WriteLine("2: View recipe categories");
            Console.WriteLine("3: Update/Remove a recipe");
            Console.WriteLine("4: Add a category");
            Console.WriteLine("5: View category");
            Console.WriteLine("6: Update/Remove a category");
        }
    }
}
