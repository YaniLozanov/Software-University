using System;
using System.Collections.Generic;

namespace Primes_in_Given_Range
{
    class Program
    {
        // Problem:
        //Write a method that calculates all prime numbers in given range and returns them as list of integers:

        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", PrintAllPrimeNumbers(startNum, stopNum).ToArray());

            Console.WriteLine(numbers);
        }

        static List<int> PrintAllPrimeNumbers(int startNum, int stopNum)
        {
            var result = new List<int>();

            for (int i = startNum; i <= startNum; i++)
            {
                result.Add(i);
            }

            return result;
        }
    }
}
