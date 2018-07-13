using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that finds the longest increasing subsequence in an array of integers.
            // The longest increasing subsequence is a portion of the array (subsequence) that is strongly increasing and has the longest possible length. 
            // If several such subsequences exist, find the left most of them.


            int[] sequece = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            int barier = 0;
            int maxLenght = 0;
            int start = 0;

            for (int i = 0; i < sequece.Length - 1; i++)
            {
                if (sequece[i + 1] > sequece[i])
                {
                    counter++;
                    if (counter > barier)
                    {
                        barier = counter;
                        start = i;
                        maxLenght = barier;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            int[] printARR = new int[barier + 1];

            for (int i = 0; i <= barier; i++)
            {
                printARR[i] = sequece[start - i + 1];

            }

            Console.WriteLine(string.Join(" ", printARR.Reverse()));

        }
    }
}
