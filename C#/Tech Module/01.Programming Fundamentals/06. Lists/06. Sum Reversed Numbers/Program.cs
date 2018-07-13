using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        // Problem:
        // Write a program that reads sequence of numbers, reverses their digits, and prints their sum.

        static void Main(string[] args)
        {
            int sum = Console.ReadLine().Split(' ').Select(e => new String(e.Reverse().ToArray())).Sum(e => int.Parse(e));
            Console.WriteLine(sum);


        }
    }
}
