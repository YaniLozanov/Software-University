using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the system.
            // For every given ingredient, you should write: “Adding ingredient {name of the ingredient}.”.
            // When you receive the command “Bake!” from the console you should stop the program and write “Preparing cake with {number of given ingredients} ingredients.”. 

            string command = string.Empty;
            int numOfIngredients = 0;

            while (command != "Bake!")
            {
                command = Console.ReadLine();

                if (command != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {command}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {numOfIngredients} ingredients.");
                }
                numOfIngredients++;

            }
        }
    }
}
