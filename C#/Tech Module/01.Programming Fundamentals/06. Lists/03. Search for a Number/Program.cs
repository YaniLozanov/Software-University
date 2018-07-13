using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // On the first line, you will receive a list of integers.
            // On the next line, you will receive an array with exactly three numbers.
            // First number represents the number of elements you have to take from the list (starting from the first one).
            // Second number represents the number of elements you have to delete from the numbers you took (starting from the first one).
            // Last number is the number we search in our collection after the manipulations.
            // If it is present print: “YES!”, otherwise print “NO!”


            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] operators = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            TakeNumbers(numbers, operators);
            DeleteNumbers(numbers, operators);

            bool numPresent = CheckForTheNum(numbers, operators);

            if (numPresent)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }

        private static bool CheckForTheNum(List<int> numbers, int[] operators)
        {
            if (numbers.Contains(operators[2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void DeleteNumbers(List<int> numbers, int[] operators)
        {
            for (int i = 0; i < operators[1]; i++)
            {
                numbers.RemoveAt(0);
            }
        }

        private static void TakeNumbers(List<int> numbers, int[] operators)
        {
            for (int i = 0; i < numbers.Count - operators[0]; i++)
            {
                numbers.Remove(numbers.Count - i);
            }
        }
    }
}



