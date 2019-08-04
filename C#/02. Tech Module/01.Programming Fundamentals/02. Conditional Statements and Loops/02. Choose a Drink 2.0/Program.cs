using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Your program needs to get smarter. 
            // Now you will receive on the second line the quantities of the drink and you have to print the calculated the price.
            // You can see the prices of the drinks in the table below:
           // Water Coffee  Beer Tea
            // Price   0.70    1.00    1.70    1.20


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
