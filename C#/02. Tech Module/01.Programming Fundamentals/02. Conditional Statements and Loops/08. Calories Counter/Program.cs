using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // You have to write a program, which counts the calories, which can be found in your pizza recipe. 
            // In your recipe, there are only four ingredients – cheese, tomato sauce, salami and pepper.
            // Each ingredient contains a fixed amount of calories: 

            // Cheese – 500 calories
            // Tomato sauce – 150 calories
            // Salami – 600 calories
            // Pepper – 50 calories

            // If you receive one of these ingredients more than once, you should add the calories to the total amount again.
            // You should not process any other ingredients.Ingredients are case-insensitive.


            int kindsOfIngredients = int.Parse(Console.ReadLine());

            int calories = 0;


            for (int i = 1; i <= kindsOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    calories += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredient == "salami")
                {
                    calories += 600;
                }
                else if (ingredient == "pepper")
                {
                    calories += 50;
                }

            }

            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
