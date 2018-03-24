using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            var number = double.Parse(Console.ReadLine());

            var dayWork = dayOfTheWeek == "Monday" ||
                          dayOfTheWeek == "Tuesday" ||
                          dayOfTheWeek == "Wednesday" ||
                          dayOfTheWeek == "Thursday" ||
                          dayOfTheWeek == "Friday";

            var weekend = dayOfTheWeek == "Saturday" ||
                          dayOfTheWeek == "Sunday";

            var fruits = fruit == "banana" ||
                         fruit == "apple" ||
                         fruit == "orange" ||
                         fruit == "grapefruit" ||
                         fruit == "kiwi" ||
                         fruit == "pineapple" ||
                         fruit == "grapes";

            var price = -1.0;

            if (dayWork)
            {
                if (fruits)
                {
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            break;
                        case "apple":
                            price = 1.20;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "kiwi":
                            price = 2.70;
                            break;
                        case "pineapple":
                            price = 5.50;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }

                    Console.WriteLine(number * price);               
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (weekend)
            {
                if (fruits)
                {
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.90;
                            break;
                        case "grapefruit":
                            price = 1.60;
                            break;
                        case "kiwi":
                            price = 3.00;
                            break;
                        case "pineapple":
                            price = 5.60;
                            break;
                        case "grapes":
                            price = 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }

                    Console.WriteLine(price * number);
                }
            }
            else if (price < 0)
            {
                Console.WriteLine("error");
            }
        }
    }
}
