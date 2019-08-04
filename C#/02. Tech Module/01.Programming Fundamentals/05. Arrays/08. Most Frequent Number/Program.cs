using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program that finds the most frequent number in a given sequence of numbers. 
            // Numbers will be in the range[0…65535].
            // In case of multiple numbers with the same maximal frequency, print the left most of them.


            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int counter = 0;
            int barier = 0;
            int num = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        counter++;
                        if (counter > barier)
                        {
                            barier = counter;
                            num = numbers[i];
                        }

                    }
                }
                counter = 0;
            }

            Console.WriteLine(num);
        }
    }
}
