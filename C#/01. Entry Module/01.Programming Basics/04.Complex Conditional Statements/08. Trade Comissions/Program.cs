using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sells = double.Parse(Console.ReadLine());

            var firstComission = sells >= 0 && sells <= 500;
            var secondComission = sells > 500 && sells <= 1000;
            var thirdComission = sells > 1000 && sells <= 10000;
            var fourthComission = sells > 10000;

            var correctSells = firstComission ||
                               secondComission ||
                               thirdComission ||
                               fourthComission;

            var correctTown = town == "Sofia" ||
                              town == "Varna" ||
                              town == "Plovdiv";
            var comission = 0.0;

            if (correctTown)
            {
                if (correctSells)
                {
                    switch (town)
                    {
                        case "Sofia":
                            if (firstComission)
                            {
                                comission = sells / 100 * 5;
                            }
                            else if (secondComission)
                            {
                                comission = sells / 100 * 7;
                            }
                            else if (thirdComission)
                            {
                                comission = sells / 100 * 8;
                            }
                            else if (fourthComission)
                            {
                                comission = sells / 100 * 12;
                            }
                            break;
                        case "Varna":
                            if (firstComission)
                            {
                                comission = sells / 100 * 4.5;
                            }
                            else if (secondComission)
                            {
                                comission = sells / 100 * 7.5;
                            }
                            else if (thirdComission)
                            {
                                comission = sells / 100 * 10;
                            }
                            else if (fourthComission)
                            {
                                comission = sells / 100 * 13;
                            }
                            break;
                        case "Plovdiv":
                            if (firstComission)
                            {
                                comission = sells / 100 * 5.5;
                            }
                            else if (secondComission)
                            {
                                comission = sells / 100 * 8;
                            }
                            else if (thirdComission)
                            {
                                comission = sells / 100 * 12;
                            }
                            else if (fourthComission)
                            {
                                comission = sells / 100 * 14.5;
                            }
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine($"{comission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
