using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program, which reads a list of integers from the console and receives commands, which manipulate the list. Your program may receive the following commands: 
            // Delete { element} – delete all elements in the array, which are equal to the given element
            // Insert { element}{ position} – insert element and the given position
            // You should stop the program when you receive the command Odd or Even.
            // If you receive Odd  print all odd numbers in the array separated with single whitespace, otherwise print the even numbers.


            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> commands = new List<string>();

            string stopWord = string.Empty;

            while (stopWord != "Odd" && stopWord != "Even")
            {
                commands = Console.ReadLine().Split(' ').ToList();
                stopWord = commands[0];

                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                if (commands[0] == "Even")
                {
                    numbers.RemoveAll(x => x % 2 != 0);

                    Console.WriteLine(string.Join(" ", numbers));
                }
                else if (commands[0] == "Odd")
                {
                    numbers.RemoveAll(x => x % 2 == 0);

                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
    }
}
