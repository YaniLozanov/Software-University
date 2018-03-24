using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        // Problem:
        // Write a program that reads sequence of numbers and special bomb number with a certain power.
        // Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors from left and right.
        // Detonations are performed from left to right and all detonated numbers disappear.
        // Finally print the sum of the remaining elements in the sequence.

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            // Bombs parameters: [0] = The number of the bomb.
            //                   [1] = The range of the bomb.
            List<int> bombParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombParameters[0])
                {
                    // 1.if: The bomb`s range is IN the List`s range.
                    // 2.if: The bomb`s range is UNDER List`s range.
                    // 3.if: The bomb`s range is OVER the List`s range.
                    if (bombParameters[1] + i < numbers.Count && i - bombParameters[1] >= 0   )
                    {
                        numbers.RemoveRange(i - bombParameters[1], bombParameters[1] * 2 + 1);
                    }
                    else if (i - bombParameters[1] <= 0)
                    {
                        numbers.RemoveRange(0,(i - 0) + 1 + bombParameters[1] );

                    }
                    else
                    {
                        numbers.RemoveRange(i - bombParameters[1],bombParameters[1] + 1 + (numbers.Count - i - 1) );
                        
                    }
                    i = 0;
                }
            }    
            // Print the sum.
            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}
