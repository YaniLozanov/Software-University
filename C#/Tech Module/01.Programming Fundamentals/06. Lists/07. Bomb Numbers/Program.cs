using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program that reads sequence of numbers and special bomb number with a certain power.
            // Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors from left and right.
            // Detonations are performed from left to right and all detonated numbers disappear.
            // Finally print the sum of the remaining elements in the sequence.


            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); ;


            int bombsIndex = 0;

            while (true)
            {
                if (numbers.Contains(bomb[0]))
                {
                    bombsIndex = numbers.IndexOf(bomb[0]);

                    if (bombsIndex + bomb[1] <= numbers.Count &&
                        bombsIndex - bomb[1] >= 0)
                    {
                        numbers.RemoveRange(bombsIndex - bomb[1], bomb[1] * 2 + 1);
                    }
                    else
                    {
                        if (bombsIndex + bomb[1] > numbers.Count &&
                            bombsIndex - bomb[1] >= 0)
                        {
                            numbers.RemoveRange(bombsIndex - bomb[1], bomb[1] + (numbers.Count - bombsIndex));
                        }
                        else if (bombsIndex + bomb[1] > numbers.Count - bomb[1] &&
                                 bombsIndex - bomb[1] < 0)
                        {
                            numbers.RemoveAll(x => x == x);
                        }
                        else if (bombsIndex + bomb[1] <= numbers.Count &&
                                 bombsIndex - bomb[1] < 0)
                        {
                            numbers.RemoveRange(0, bomb[1] + 1);
                        }

                    }
                }
                else
                {
                    Console.WriteLine(numbers.Sum());
                    return;
                }
            }
        }
    }
}
