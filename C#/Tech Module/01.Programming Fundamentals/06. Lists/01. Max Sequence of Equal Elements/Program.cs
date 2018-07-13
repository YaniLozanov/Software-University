using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            // Proble:
            // Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = 1;
            int barier = 0;
            int num = 0;


            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > barier)
                {
                    barier = counter;
                    num = numbers[i];
                }
            }

            for (int i = 0; i < barier; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
