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
            // Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower two rows (each holding 2 * k integers):
            // 

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int[] arrUp = new int[numbers.Length / 2];
            int[] arrDown = new int[numbers.Length / 2];
            int[] arrSum = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (i < numbers.Length / 4)
                {
                    arrUp[arrUp.Length - arrUp.Length / 2 - i - 1] = numbers[i];
                }
                else
                {
                    arrUp[arrUp.Length - i + numbers.Length / 4 - 1] = numbers[i + numbers.Length / 2];
                }

                arrDown[i] = numbers[i + numbers.Length / 4];
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                arrSum[i] = arrDown[i] + arrUp[i];
            }

            Console.WriteLine(string.Join(" ", arrSum));
        }
    }
}
