using System;
using System.Linq;
namespace Rotate_and_Sum
{
    class Program
    {
        // Problem:
        // To “rotate an array on the right” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
        // Write a program to read an array of n integers(space separated on a single line) and an integer k,
        // rotate the array right k times and sum the obtained arrays after each rotation as shown below.

        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotatingIndex = int.Parse(Console.ReadLine());

            // Find the rotated number
            int[] rotatedArr = new int[inputArr.Length];

            // Find the total sum
            int[] sum = new int[inputArr.Length];

            for (int firstCycle = 1; firstCycle <= rotatingIndex; firstCycle++)
            {
                // Find the rotated inputArr.
                RotateTheArr(inputArr, rotatedArr);

                // Set the inputArr.
                SetTheInputArr(inputArr, rotatedArr);

                // Find the total sum.
                FindTheSum(sum, rotatedArr);
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static void FindTheSum(int[] sum, int[] rotatedArr)
        {
            for (int firstCycle = 0; firstCycle < sum.Length; firstCycle++)
            {
                sum[firstCycle] += rotatedArr[firstCycle];
            }
        }

        private static void SetTheInputArr(int[] inputArr, int[] rotatedArr)
        {
            for (int firstCycle = 0; firstCycle < inputArr.Length; firstCycle++)
            {
                inputArr[firstCycle] = rotatedArr[firstCycle];
            }
        }

        private static void RotateTheArr(int[] inputArr, int[] rotatedArr)
        {

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (i == 0)
                {
                    rotatedArr[i] = inputArr[inputArr.Length - 1];
                }
                else
                {
                    rotatedArr[i] = inputArr[i - 1];
                }
            }



        }
    }
}
