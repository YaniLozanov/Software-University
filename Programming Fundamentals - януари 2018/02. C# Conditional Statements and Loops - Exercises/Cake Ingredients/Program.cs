using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
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
