using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
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
