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
            int[] numberAndRepeat = new int[inputNums.Length];

            // Find the longest sequence.
            FindTheLongestSequence(inputNums, numberAndRepeat);

            // Print the result : The longest sequence of equal elements. 
            PrintTheLongestSequence(numberAndRepeat);
        }

        private static void PrintTheLongestSequence(int[] numberAndRepeat)
        {
            

            for (int firstCycle = 0; firstCycle < numberAndRepeat.Length; firstCycle++)
            {
                if (numberAndRepeat[firstCycle] != 0)
                {

                    Console.Write($"{numberAndRepeat[firstCycle]} ");
                }
            }
            Console.WriteLine();
        }

        private static void FindTheLongestSequence(int[] inputNums, int[] numbers)
        {
            int count = 0;
            int secondCount = 0;

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

                if (secondCount <=  count && inputNums[firstCycle - 1] + 1 == inputNums[firstCycle])
                {
                    secondCount++;
                    numbers[count - 1] = inputNums[firstCycle - 1];
                    numbers[count] = inputNums[firstCycle];
                   

                }
            }
            
        }
    }
}
