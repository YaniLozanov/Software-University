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

            UltimateArr(numbers);


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();

        }



        private static int something(int[] numbers)
        {
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    index++;
                }
            }
            return index;


        }

        private static void UltimateArr(int[] numbers)
        {
            for (int k = 0; k < numbers.Length; k++)
            {
                if (numbers[k] != 0)
                {

                    for (int i = 4 + k; i < numbers.Length + 2; i++)
                    {
                        if (i % numbers[k] == 0)
                        {
                            numbers[i - 2] = 0;
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

