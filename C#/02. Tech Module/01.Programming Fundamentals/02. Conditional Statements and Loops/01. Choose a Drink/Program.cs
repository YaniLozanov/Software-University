using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program, which receives a profession (as a string) and chooses the perfect drink for the person.
            // The possible combinations are: 

            //“Water” – for “Athlete”
            //“Coffee” – for “Businessman” or “Businesswoman”
            //“Beer” – for “SoftUni Student”
            //“Tea” – for all other professions.


            string person = Console.ReadLine().ToLower();

            if (person == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (person == "businessman")
            {
                Console.WriteLine("Coffee");
            }
            else if (person == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (person == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
