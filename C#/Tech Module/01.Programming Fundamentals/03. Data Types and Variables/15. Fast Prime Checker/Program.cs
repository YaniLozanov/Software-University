using System;

namespace Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // You are given a program that checks if numbers in a given range [2...N] are prime. 
            // For each number is printed "{number} -> {True or False}". The code however, is not very well written.
            // Your job is to modify it in a way that is easy to read and understand.


            int number = int.Parse(Console.ReadLine());

            for (int firstCycle = 2; firstCycle <= number; firstCycle++)
            {
                bool prime = true;

                for (int secondCylce = 2; secondCylce <= Math.Sqrt(firstCycle); secondCylce++)
                {
                    if (firstCycle % secondCylce == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstCycle} -> {prime}");
            }

        }
    }
}
