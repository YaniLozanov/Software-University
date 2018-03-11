using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeoples = int.Parse(Console.ReadLine());
            string kindPackage = Console.ReadLine();

            string kindOfHall = string.Empty;
            double price = 0.0;
            double discountInProcent = 0.0;

            if (numOfPeoples <= 50)
            {
                price = 2500;
                kindOfHall = "Small Hall";
            }
            else if (numOfPeoples <= 100)
            {
                price = 5000;
                kindOfHall = "Terrace";
            }
            else if (numOfPeoples <= 120)
            {
                price = 7500;
                kindOfHall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (kindPackage == "Normal")
            {
                discountInProcent = 0.05;
                price += 500;
            }
            else if (kindPackage == "Gold")
            {
                discountInProcent = 0.1;
                price += 750;
            }
            else if (kindPackage == "Platinum")
            {
                discountInProcent = 0.15;
                price += 1000;
            }

            double discount = price * discountInProcent;
            double finalPrice = price - discount;
            double pricePerPerson = finalPrice / numOfPeoples;

            Console.WriteLine($"We can offer you the {kindOfHall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
