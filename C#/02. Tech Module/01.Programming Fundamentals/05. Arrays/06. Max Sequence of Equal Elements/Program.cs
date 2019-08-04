using System;
using System.Linq;

namespace _6._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program that finds the longest sequence of equal elements in an array of integers. 
            // If several longest sequences exist, print the leftmost one.


            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int counter = 0;
            int barrier = 0;
            int num = 0;


            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    counter++;
                    if (counter > barrier)
                    {                                           //  1 2 5 2 2 2
                        barrier = counter;
                        num = sequence[i];

                    }
                }
                else
                {
                    counter = 0;
                }

            }

            for (int print = 0; print <= barrier; print++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

        }
    }
}
