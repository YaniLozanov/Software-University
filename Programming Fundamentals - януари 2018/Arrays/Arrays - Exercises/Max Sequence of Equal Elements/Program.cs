using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        //Problem:
        // Write a program that finds the longest sequence of equal elements in an array of integers.
        //If several longest sequences exist, print the leftmost one.

        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Save the number and how many time number is repeated.
            int[] numberAndRepeat = new int[2];

            // Find the longest sequence.
            FindTheLongestSequence(inputNums, numberAndRepeat);

            // Print the result : The longest sequence of equal elements. 
            PrintTheLongestSequence(numberAndRepeat);



        }

        private static void PrintTheLongestSequence(int[] numbers)
        {
            for (int firstCycle = 0; firstCycle < numbers[1]; firstCycle++)
            {
                Console.Write($"{numbers[0]} ");
            }
            Console.WriteLine();
        }

        private static void FindTheLongestSequence(int[] inputNums, int[] numbers)
        {
            int count = 0;

            for (int firstCycle = 1; firstCycle < inputNums.Length; firstCycle++)
            {
                if (inputNums[firstCycle - 1] + 1 == inputNums[firstCycle])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (numbers[1] <= count)
                {
                    numbers[0] = inputNums[firstCycle];
                    numbers[1] = count + 1;
                }
            }
        }
    }
}
