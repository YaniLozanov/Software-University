using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


namespace _05._Key_Replacer
{
    class KeyReplacer
    {
        // Problem:
        // You will be given a key string and a text string. The key string will contain a start key and an end key.
        // The start key starts at the beginning of the string and ends at the first occurrence of one of the symbols – “|”, “<” or “\”. The end key starts at the last occurrence of one of these symbols and ends when the string ends.Both keys can contain only Latin alphabet letters.
        // When you extract both keys search for them in the text string and extract every string, which is between them. Concatenate all collected strings and print the result. If the result string is empty print “Empty result”.

        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            int counter = 0;   // We use it to check: how much matches != strin.Empty we have.
            string keyStringPattern = @"(^[A-Za-z]+)(\<|\||\\)(\w+|\W+)(\<|\||\\)([A-Za-z]+)$";

            var keyStringMatches = Regex.Matches(keyString, keyStringPattern); // Match the keywords.

            foreach (Match keyMatch in keyStringMatches)
            {               
                string textStringPattern = $@"{keyMatch.Groups[1]}(?<word>.*?){keyMatch.Groups[5]}";

                MatchCollection textStringMatches = Regex.Matches(textString, textStringPattern); // Match the text between the keywords.

                foreach (Match textMatch in textStringMatches.Where(x => x.Groups["word"].Value.ToString() != string.Empty)) // Delete the Empty strings.
                {
                    counter++;
                        Console.Write(textMatch.Groups["word"].Value.ToString()); // Print the result.        
                }
                if (counter == 0)
                {
                    Console.WriteLine("Empty result"); // If there is no match print: Empty result.
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
