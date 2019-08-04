using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            //Write a program that reads an array of integers from the console and set of commands and executes them over the array.
            // The commands are as follows:

            // add<index> < element > – adds element at the specified index(elements right from this position inclusively are shifted to the right).
            // addMany<index> < element 1 > < element 2 > … < element n > – adds a set of elements at the specified index.

            // contains < element > – prints the index of the first occurrence of the specified element(if exists) in the array or - 1 if the element is not found.
            // remove < index > – removes the element at the specified index.
            //  shift < positions > – shifts every element of the array the number of positions to the left(with rotation).
            // For example, [1, 2, 3, 4, 5] -> shift 2-> [3, 4, 5, 1, 2]
            // sumPairs – sums the elements in the array by pairs(first +second, third + fourth, …).
            // For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
            //print – stop receiving more commands and print the last state of the array.


            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> commands = new List<string>();

            string stopWord = string.Empty;



            while (true)
            {
                commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "add")
                {
                    AddNum(numbers, commands);
                }
                else if (commands[0] == "addMany")
                {
                    AddManyNum(numbers, commands);
                }
                else if (commands[0] == "contains")
                {
                    ContainsNum(numbers, commands);
                }
                else if (commands[0] == "remove")
                {
                    RemoveNumAtIndex(numbers, commands);
                }
                else if (commands[0] == "shift")
                {
                    ShiftNum(numbers, commands);
                }
                else if (commands[0] == "sumPairs")
                {
                    SumPairsOfNums(numbers, commands);
                }
                else if (commands[0] == "print")
                {
                    PrintTheArr(numbers);
                    return;
                }

            }
        }

        private static void PrintTheArr(List<int> numbers)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("]");
        }

        private static void SumPairsOfNums(List<int> numbers, List<string> commands)
        {
            // 3 3 4 5
            // 1 2 3 4 5

            int lenght = numbers.Count;
            for (int i = 0; i < lenght / 2; i++)
            {
                numbers[i] = numbers[i] + numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        private static void ShiftNum(List<int> numbers, List<string> commands)
        {
            int saveFirstNum = 0;

            for (int i = 1; i <= int.Parse(commands[1]); i++)
            {
                saveFirstNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(saveFirstNum);

            }
        }

        private static void RemoveNumAtIndex(List<int> numbers, List<string> commands)
        {
            numbers.RemoveAt(int.Parse(commands[1]));
        }

        private static void ContainsNum(List<int> numbers, List<string> commands)
        {
            if (numbers.Contains(int.Parse(commands[1])))
            {
                Console.WriteLine(numbers.IndexOf(int.Parse(commands[1])));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static void AddManyNum(List<int> numbers, List<string> commands)
        {
            for (int i = commands.Count - 1; i >= 2; i--)
            {
                numbers.Insert(int.Parse(commands[1]), int.Parse(commands[i]));
            }
        }

        private static void AddNum(List<int> numbers, List<string> commands)
        {
            numbers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
        }
    }
}
