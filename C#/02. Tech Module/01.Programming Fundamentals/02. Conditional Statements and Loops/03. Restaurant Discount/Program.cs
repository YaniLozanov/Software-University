using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // A restaurant want to automate their reservation process. They need a program that reads the hall and the count of people from the console and calculates how much the customer should pay to book the place.
            // Different halls have different prices:
            // Small Hall  Terrace Great Hall
            // Price   2500$	5000$	7500$
            // Capacity    50  100 120
            // The restaurant has discounts depending on the service package, which the group wants. 
            // You can see the discounts in the table below:
            // Normal Gold    Platinum
            // Discount    5 % 10 % 15 %
            // Price   500$	750$	1000$
            // You should add the price of the package to the price of the hall. The discount is calculated based on the hall’s price +package’s price.
            // Example: The group has 10 people and wants the gold package  $292.50 per person:
            // 10 people <= 50  they get the Small Hall  $2500
            // Gold package  $750, 10 % discount on the entire purchase
            // Total price: $2500 + $750 = $3250
            // Discount: $3250 - 10 % discount = $2925
            // Price per person: $2925 / 10 people = $292.50 per person
            // You should print which hall is the most suitable for the group and the price per person.
            // If the group is bigger than 120 people – print “We do not have an appropriate hall.”.


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
