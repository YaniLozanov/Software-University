﻿using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program, which receives a number – n, and prints a triangle from 1 to n as in the examples.

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
