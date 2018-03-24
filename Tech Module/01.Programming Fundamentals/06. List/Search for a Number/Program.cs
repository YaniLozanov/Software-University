using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        // Problem:
        // On the first line, you will receive a list of integers.
        // On the next line, you will receive an array with exactly three numbers.
        // First number represents the number of elements you have to take from the list (starting from the first one).
        // Second number represents the number of elements you have to delete from the numbers you took (starting from the first one).
        // Last number is the number we search in our collection after the manipulations. If it is present print: “YES!”, otherwise print “NO!”. 

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] operators = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Find the number of elements.
            numbers = FirstManipulation(numbers, operators);

            // Remove the numbers in range.
            numbers = SecondManipulation(numbers, operators);

            // Check: is the last number from the operators in the list "numbers".
            bool isTheStillNumberThere = ThirdManipulatiom(numbers, operators);

            // Print: is the last number from the operators in the list "numbers".
            PrintTheResult(isTheStillNumberThere);
            
        }

        private static void PrintTheResult(bool isTheStillNumberThere)
        {
            if (isTheStillNumberThere)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

        private static bool ThirdManipulatiom(List<int> numbers, int[] operators)
        {
            int result = numbers.Find(item => item == operators[2]);

            if (result == operators[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<int> SecondManipulation(List<int> numbers, int[] operators)
        {
            numbers.RemoveRange(0, operators[1]);
            return numbers;
        }

        private static List<int> FirstManipulation(List<int> numbers, int[] operators)
        {
            numbers.RemoveRange(operators[0], numbers.Count - operators[0]);
            return numbers;
        }
    }
}
