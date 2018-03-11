using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (person == "Athlete")
            {
                Console.WriteLine($"The {person} has to pay {(quantity * 0.7):f2}.");
            }
            else if (person == "Businessman")
            {
                Console.WriteLine($"The {person} has to pay {(quantity * 1.00):f2}.");

            }
            else if (person == "Businesswoman")
            {
                Console.WriteLine($"The {person} has to pay {(quantity * 1.00):f2}.");

            }
            else if (person == "SoftUni Student")
            {
                Console.WriteLine($"The {person} has to pay {(quantity * 1.70):f2}.");
            }
            else
            {
                Console.WriteLine($"The {person} has to pay {(quantity * 1.20):f2}.");
            }
        }
    }
}
