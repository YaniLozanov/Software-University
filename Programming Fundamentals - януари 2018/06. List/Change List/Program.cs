using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        // Problem:
        // Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
        // Your program may receive the following commands: 

        // Delete {element} – delete all elements in the array, which are equal to the given element

        // Insert {element} {position} – insert element and the given position

        // You should stop the program when you receive the command Odd or Even.If you receive Odd  print all odd numbers in the array separated with single whitespace,
        // otherwise print the even numbers.


        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = new List<string>();

            // It says, when program have to stop.
            string stopWord = string.Empty;

            while (stopWord != "Odd" && stopWord != "Even")
            {
                command = Console.ReadLine().Split(' ').ToList();

                // Check which command is used and execute it.
                ЕxecuteTheCommand(command, numbers);


                stopWord = command[0];

            }

            // Remove the Odd or the Even numbers and print the result.
            PrintTheResult(stopWord, numbers);
            
        }

        private static void ЕxecuteTheCommand(List<string> command, List<int> numbers)
        {
            // Check the command.
            if (command[0] == "Delete")
            {
                numbers.RemoveAll(item => item == int.Parse(command[1]));
            }
            else if (command[0] == "Insert")
            {
                numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
            }
        }

        private static void PrintTheResult(string stopWord, List<int> numbers)
        {
            if (stopWord == "Odd")
            {
                numbers.RemoveAll(item => item % 2 == 0);
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                numbers.RemoveAll(item => item % 2 != 0);
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
