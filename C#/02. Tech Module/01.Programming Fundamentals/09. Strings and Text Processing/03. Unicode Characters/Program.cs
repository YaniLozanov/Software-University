using System;

class UnicodeCharacters
{
    static void Main()
    {
        // Problem:
        // Write a program that converts a string to a sequence of Unicode character literals.

        string input = Console.ReadLine();

        foreach (var chr in input)
        {
            Console.Write("\\u{0:x4}", (int)chr);
        }
        Console.WriteLine();
    }
}