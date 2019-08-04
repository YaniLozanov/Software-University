using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that count the number of pairs in given array which difference is equal to given number.

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = int.Parse(Console.ReadLine());


            int counter = 0;
            int d = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] - numbers[k] == result || numbers[k] - numbers[i] == result) // 1 5 3 4 2
                    {
                        counter++;

                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
