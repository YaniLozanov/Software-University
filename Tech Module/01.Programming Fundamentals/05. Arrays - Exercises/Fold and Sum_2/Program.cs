using System;
using System.Linq;
namespace Fold_and_Sum_2
{
    class Program
    {
        // Problem:
        // Read an array of 4*k integers, fold it like shown below,
        // and print the sum of the upper and lower two rows (each holding 2 * k integers):
        //int[] secondArr = new int[inputArr.Length / 2];

        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Firs row.
            int[] firstRow = new int[inputArr.Length / 2];

            // Second row.
            int[] secondRow = new int[inputArr.Length / 2];

            // The sum of firs and second row.
            int[] sum = new int[inputArr.Length / 2];

            // Find the first row.
            FindTheFirstRow(inputArr, firstRow);

            // Find the second row.
            FindTheSecondRow(inputArr, secondRow);

            // Find the sum of first and second row.
            FindTheSum(firstRow, secondRow, sum);

            Console.WriteLine(string.Join(" ", sum));

        }

        private static void FindTheSum(int[] firstRow, int[] secondRow, int[] sum)
        {
            for (int firstCycle = 0; firstCycle < firstRow.Length; firstCycle++)
            {
                sum[firstCycle] = firstRow[firstCycle] + secondRow[firstCycle];
            }
        }

        private static void FindTheSecondRow(int[] inputArr, int[] secondRow)
        {
            for (int firstCylce = 0; firstCylce < inputArr.Length / 2; firstCylce++)
            {
                secondRow[firstCylce] = inputArr[inputArr.Length / 4 + firstCylce];
            }
        }

        private static void FindTheFirstRow(int[] inputArr, int[] firstArr)
        {


            for (int firstCycle = 0; firstCycle < inputArr.Length / 4; firstCycle++)
            {
                firstArr[inputArr.Length / 4 - 1 - firstCycle] = inputArr[firstCycle];
                firstArr[inputArr.Length / 2 - 1 - firstCycle] = inputArr[inputArr.Length - inputArr.Length / 4 + firstCycle];
            }



        }
    }
}
