using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Valid_Usernames
{
    class ValidUsernames
    {
        // Problem:
        // You are part of the back-end development team of the next Facebook.
        //  You are given a line of usernames, separated by one of the following symbols: “ ”, “/”, “\”, “(“, “)”.
        //  First you have to export all valid usernames.
        // A valid username starts with a letter and can only contain letters, digits and underscores “_”.
        // It cannot be less than 3 or more than 25 symbols long.
        //  Your task is to sum the length of every 2 consecutive valid usernames and print the 2 valid usernames with biggest sum of their lengths, on the console, each on a separate line.

        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"\b[A-Za-z]\w{2,25}\b";

            MatchCollection validUsernames = Regex.Matches(inputText, pattern);

            var listWithUsernames = new List<string> { };

            // Turn the MatchCollection in to list for easier work with it.
            listWithUsernames = validUsernames.Select(x => x.ToString()).ToList();  

            // Find and print the two usenrnames with the longest lenght.
            GiveTheLongestSum(listWithUsernames);


        }

        private static void PrintTheResult(List<string> listWithUsernames)
        {
            Console.WriteLine(string.Join("\n", listWithUsernames));
        }

        private static void GiveTheLongestSum(List<string> listWithUsernames)
        {
            int sum = 0;
            int barier = 0;
            string[] saveTheUsernames = new string[2];

            for (int i = 0; i < listWithUsernames.Count - 1; i++)
            {
                sum = listWithUsernames[i].Length + listWithUsernames[i + 1].Length;

                if (barier < sum)
                {
                    barier = sum;

                    saveTheUsernames[0] = listWithUsernames[i];
                    saveTheUsernames[1] = listWithUsernames[i + 1];
                }
            }

            Console.WriteLine(saveTheUsernames[0]);
            Console.WriteLine(saveTheUsernames[1]);
        }
    }
}
