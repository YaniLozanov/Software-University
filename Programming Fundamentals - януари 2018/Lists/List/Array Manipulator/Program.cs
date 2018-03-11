using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    // Problems:
    // Write a program that reads an array of integers from the console and set of commands and executes them over the array.
    // The commands are as follows:

    // ⦁	 add <index> <element> – adds element at the specified index(elements right from this position inclusively are shifted to the right).

    // ⦁ addMany<index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index.

    // ⦁ contains<element> – prints the index of the first occurrence of the specified element(if exists) in the array or -1 if the element is not found.

    // ⦁	 remove<index> – removes the element at the specified index.

    // ⦁	 shift<positions> – shifts every element of the array the number of positions to the left (with rotation).

    // ⦁	 For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]

    // ⦁ sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).

    // ⦁ For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].

    // ⦁	 print – stop receiving more commands and print the last state of the array.


    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> manipilator = new List<string>();

            // When the word "stopWord" is == "print" the program stops.
            string stopWord = string.Empty;

            // Manipulators
            string add = "add";
            string addMany = "addMany";
            string contains = "contains";
            string remove = "remove";
            string shift = "shift";
            string sumPairs = "sumPairs";
            string print = "print";

            while (stopWord != print)
            {
                manipilator = Console.ReadLine().Split(' ').ToList();

                if (manipilator[0] == add)
                {
                    // Adds element at the specified index.
                    numbers = AddElement(numbers, manipilator);
                }
                else if (manipilator[0] == addMany)
                {
                    // Adds a set of elements at the specified index.
                    numbers = AddSetOfElements(numbers, manipilator);
                }
                else if (manipilator[0] == contains)
                {
                    // Prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found.
                    PrintTheIndex(numbers, manipilator);
                }
                else if (manipilator[0] == remove)
                {
                    // Removes the element at the specified index.
                    numbers = RemoveElement(numbers, manipilator);
                }
                else if (manipilator[0] == shift)
                {
                    // Every element of the array the number of positions to the left.
                    numbers = ShiftTheElemtnts(numbers, manipilator);
                }
                else if (manipilator[0] == sumPairs)
                {
                    // Sums the elements in the array by pairs (first + second, third + fourth, …).
                    numbers = FindTheSumOfTheElements(numbers, manipilator);
                }
                else
                {
                    break;
                }

                stopWord = manipilator[0];
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

        }

        private static List<int> FindTheSumOfTheElements(List<int> numbers, List<string> manipilator)
        {
            int count = 0;
            if (numbers.Count % 2 != 0)
            {
                count = numbers.Count - 1;
            }
            else
            {
                count = numbers.Count;
            }

            for (int i = 0; i < count / 2; i++)
            {
                numbers[i] = numbers[i + i] + numbers[i + i + 1];
            }

            numbers.RemoveRange(numbers.Count / 2, numbers.Count / 2);

            return numbers;
        }

        private static List<int> ShiftTheElemtnts(List<int> numbers, List<string> manipilator)
        {
            int num = 0;

            for (int i = 0; i < int.Parse(manipilator[1]); i++)
            {
                num = numbers[0];
                numbers.Remove(num);
                numbers.Insert(numbers.Count, num);

            }

            return numbers;
        }
        private static List<int> RemoveElement(List<int> numbers, List<string> manipilator)
        {
            numbers.RemoveAt(int.Parse(manipilator[1]));

            return numbers;
        }

        private static void PrintTheIndex(List<int> numbers, List<string> manipilator)
        {
            int index = numbers.FindIndex(0, numbers.Count, item => item == int.Parse(manipilator[1]));

            Console.WriteLine(index);
        }

        private static List<int> AddSetOfElements(List<int> numbers, List<string> manipilator)
        {
            for (int i = manipilator.Count - 1; i >= 2; i--)
            {
                numbers.Insert(int.Parse(manipilator[1]), int.Parse(manipilator[i]));

            }
            return numbers;
        }

        private static List<int> AddElement(List<int> numbers, List<string> manipilator)
        {
            numbers.Insert(int.Parse(manipilator[1]), int.Parse(manipilator[2]));

            return numbers;
        }
    }
}
