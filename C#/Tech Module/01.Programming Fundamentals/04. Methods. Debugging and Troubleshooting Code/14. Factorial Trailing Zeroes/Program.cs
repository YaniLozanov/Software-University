using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        public static void Main()
        {

            // Problem:
            // Create a program that counts the trailing zeroes of the factorial of a given number.

            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            int trailZeros = 0;


            for (int i = 1; i <= number; i++)
            {
                factorial *= i;

                foreach (var symbol in factorial.ToString())
                {
                    var digits = symbol - '0';

                    if (digits == 0)
                    {
                        trailZeros++;
                    }
                    else
                    {
                        trailZeros = 0;
                    }
                }
            }
            Console.WriteLine(trailZeros);


        }
    }
}
