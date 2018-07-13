using System;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program that takes a base-10 number (0 to 1050) and converts it to a base-N number, where 2 <= N <= 10.
            // The input consists of 1 line containing two numbers separated by a single space.
            // The first number is the base N to which you should convert.
            // The second one is the base 10 number to be converted.
            // Do not use any built in converting functionality, try to write your own algorithm.
           

            string[] input = Console.ReadLine().Split(' ').ToArray();

            int n = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            string result = string.Empty;
            BigInteger reminder = 0;

            while (number > 0)
            {
                reminder = number % n;
                number /= n;

                result = reminder.ToString() + result;
            }

            Console.WriteLine(result);

        }
    }
}
