using System;
using System.Linq;

namespace _02._Rotate_and_Sum___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // To “rotate an array on the right” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
            // Write a program to read an array of n integers(space separated on a single line) and an integer k, rotate the array right k times and sum the obtained arrays after each rotation as shown below.


            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] newArr = new int[numbers.Length];
            int[] sumArr = new int[numbers.Length];

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == 0)
                    {
                        newArr[i] = numbers[numbers.Length - 1];
                    }
                    else
                    {
                        newArr[i] = numbers[i - 1];
                    }
                }

                for (int newNums = 0; newNums < numbers.Length; newNums++)
                {
                    numbers[newNums] = newArr[newNums];
                }

                for (int sum = 0; sum < numbers.Length; sum++)
                {
                    sumArr[sum] += newArr[sum];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
