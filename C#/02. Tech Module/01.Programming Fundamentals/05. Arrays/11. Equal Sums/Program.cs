using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right. 
            // If there are no elements to the left / right, their sum is considered to be 0.
            // Print the index that satisfies the required condition or “no” if there is no such index.


            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSide = 0;
            int index = 0;
            int rightSide = 0;


            for (int i = 0; i <= input.Length; i++)
            {
                for (int k = 0; k < input.Length; k++)
                {
                    if (k < i)
                    {
                        leftSide += input[k];
                    }
                    else if (k == i)
                    {
                        index = k;
                    }
                    else if (k > i)
                    {
                        rightSide += input[k];
                    }
                }

                if (leftSide == rightSide)
                {
                    Console.WriteLine(index);
                    return;
                }
                else
                {
                    leftSide = 0;
                    rightSide = 0;
                }
            }


            if (input.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
