using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        // Problem:
        // Write a program that calculates and prints the n! for any n in the range [1…1000].


        public static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
