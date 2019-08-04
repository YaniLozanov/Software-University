using System;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that creates an array containing all letters from the alphabet (a-z).
            // Read a lowercase word from the console and print the index of each of its letters in the letters array.


            string input = Console.ReadLine();

            char letter;

            for (int i = 0; i < input.Length; i++)
            {
                letter = input[i];

                Console.WriteLine($"{input[i]} -> {(int)letter - 97}");
            }
        }
    }
}
