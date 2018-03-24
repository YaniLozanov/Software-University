using System;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            // We find the factorial.
            for (int firstCycle = 1; firstCycle <= inputNum; firstCycle++)
            {
                factorial *= firstCycle;
            }

            // We find the number of zeros
            BigInteger zeros = 0;

            foreach (var symbol in factorial.ToString())
            {
                var digits = symbol - '0';

                if (digits == 0)
                {                   
                    zeros++;
                }
                else
                {
                    zeros = 0;
                }
            }
            Console.WriteLine(factorial);
            Console.WriteLine(zeros);
        }
    }
}
