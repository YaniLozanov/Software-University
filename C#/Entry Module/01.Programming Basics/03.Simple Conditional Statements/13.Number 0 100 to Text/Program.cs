using System;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= 100)
            {
                if (number >= 0)
                {
                    if (number == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    if (number == 1)
                    {
                        Console.WriteLine("one");
                    }
                    if (number == 2)
                    {
                        Console.WriteLine("two");
                    }
                    if (number == 3)
                    {
                        Console.WriteLine("three");
                    }
                    if (number == 4)
                    {
                        Console.WriteLine("four");
                    }
                    if (number == 5)
                    {
                        Console.WriteLine("five");
                    }
                    if (number == 6)
                    {
                        Console.WriteLine("six");
                    }
                    if (number == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    if (number == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    if (number == 9)
                    {
                        Console.WriteLine("nine");
                    }
                    if (number == 10)
                    {
                        Console.WriteLine("ten");
                    }
                    if (number == 11)
                    {
                        Console.WriteLine("eleven");
                    }
                    if (number == 12)
                    {
                        Console.WriteLine("twelve");
                    }
                    if (number == 13)
                    {
                        Console.WriteLine("thirteen");
                    }
                    if (number == 14)
                    {
                        Console.WriteLine("fourteen");
                    }
                    if (number == 15)
                    {
                        Console.WriteLine("fifteen");
                    }
                    if (number == 16)
                    {
                        Console.WriteLine("sixteen");
                    }
                    if (number == 17)
                    {
                        Console.WriteLine("seventeen");
                    }
                    if (number == 18)
                    {
                        Console.WriteLine("eighteen");
                    }
                    if (number == 19)
                    {
                        Console.WriteLine("nineteen");
                    }

                    if (number >= 20)
                    {
                        int firstNum = number / 10;
                        int secondNum = number % 10;

                        if (firstNum == 1)
                        {
                            Console.Write("teen");
                        }
                        else if (firstNum == 2)
                        {
                            Console.Write("twenty");
                        }
                        else if (firstNum == 3)
                        {
                            Console.Write("thirty");
                        }
                        else if (firstNum == 4)
                        {
                            Console.Write("forty");
                        }
                        else if (firstNum == 5)
                        {
                            Console.Write("fifty");
                        }
                        else if (firstNum == 6)
                        {
                            Console.Write("sixty");
                        }
                        else if (firstNum == 7)
                        {
                            Console.Write("seventy");
                        }
                        else if (firstNum == 8)
                        {
                            Console.Write("eighty");
                        }
                        else if (firstNum == 9)
                        {
                            Console.Write("ninety");
                        }
                        else if (firstNum == 10)
                        {
                            Console.WriteLine("one hundred");
                        }

                        if (secondNum == 1)
                        {
                            Console.WriteLine(" one");
                        }
                        else if (secondNum == 2)
                        {
                            Console.WriteLine(" two");
                        }
                        else if (secondNum == 3)
                        {
                            Console.WriteLine(" three");

                        }
                        else if (secondNum == 4)
                        {
                            Console.WriteLine(" four");
                        }
                        else if (secondNum == 5)
                        {
                            Console.WriteLine(" five");
                        }
                        else if (secondNum == 6)
                        {
                            Console.WriteLine(" six");
                        }
                        else if (secondNum == 7)
                        {
                            Console.WriteLine(" seven");
                        }
                        else if (secondNum == 8)
                        {
                            Console.WriteLine(" eight");
                        }
                        else if (secondNum == 9)
                        {
                            Console.WriteLine(" nine");
                        }
                    }
                }
                else if (number < 0)
                {
                    Console.WriteLine("invalid number");
                }
            }
            else if (number > 100)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
