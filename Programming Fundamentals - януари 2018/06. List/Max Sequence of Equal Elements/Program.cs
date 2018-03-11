using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        // Problem:
        // Read a list of integers and find the longest sequence of equal elements.
        // If several exist, print the leftmost.

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxCount = 0;
            int counter = 1;
            int maxNum = 0;

            for (int firstCycle = 0; firstCycle < numbers.Count - 1; firstCycle++)
            {
                if (numbers[firstCycle] == numbers[firstCycle + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxNum = numbers[firstCycle];
                }
            }

            for (int secondCylce = 0; secondCylce < maxCount; secondCylce++)
            {
                Console.Write(maxNum + " ");
            }

            Console.WriteLine();
        }
    }
}
