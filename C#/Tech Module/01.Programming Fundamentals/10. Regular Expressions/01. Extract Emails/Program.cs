using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        // Problem:
        // Write a program to extract all email addresses from a given text. 
        // The text comes at the only input line. Print the emails on the console, each at a separate line.
        // Emails are considered to be in format <user>@<host>, where: 

        // User  is a sequence of letters and digits, where '.', '-' and '_' can appear between them.

        // Host is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters.



        static void Main(string[] args)
        {
            string pattern = @"(?<=^| )\b[A-Za-z0-9](\.?-?_?\w)+\b@[A-Za-z](\.?-?\w)+\.\w+";

            string inputText = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputText, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }


        }
    }
}
