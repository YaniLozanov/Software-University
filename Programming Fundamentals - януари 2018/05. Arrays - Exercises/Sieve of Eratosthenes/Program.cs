using System;
using System.Linq;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        // Problem:
        // Write a program to find all prime numbers in range[1…n].
        // Implement the algorithm called “Sieve of Eratosthenes”: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes.
        // Steps in the “Sieve of Eratosthenes” algorithm:

        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int[] numbers = new int[inputNum - 1];

            // Fill up the Arr.
            FillTheArr(numbers);

            // Find the prime numbers.
            FindThePrimeNums(numbers);

            // Print the all prime numbers in the rage.
            PrintThePrimeNums(numbers);

        }

        private static void PrintThePrimeNums(int[] numbers)
        {
            for (int firstCylce = 0; firstCylce < numbers.Length; firstCylce++)
            {
                if (numbers[firstCylce] != 0)
                {
                    Console.Write($"{numbers[firstCylce]} ");
                }
            }
            Console.WriteLine();
        }

        private static void FindThePrimeNums(int[] numbers)
        {
            for (int firstClce = 0; firstClce < numbers.Length; firstClce++)
            {
                if (numbers[firstClce] != 0)
                {
                    
                    for (int secondCylce = 4 + firstClce; secondCylce < numbers.Length + 2  ; secondCylce++)
                    {
                        if (secondCylce % numbers[firstClce] == 0 )
                        {
                            numbers[secondCylce - 2] = 0;
                        }
                    }
                }
            }                  
        }

        private static void FillTheArr(int[] numbers)
        {
            for (int firstCycle = 2; firstCycle <= numbers.Length + 1; firstCycle++)
            {
                numbers[firstCycle - 2] = firstCycle;
            }
        }
    }
}
