using System;
using System.Numerics;
namespace Factorial
{
    class Program
    {
        // Problem:
        // Write a program that calculates and prints the n! for any n in the range[1…1000].

        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= inputNum; i++)
            {
               
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
