using System;
using System.Text.RegularExpressions;


namespace _02._Extract_Sentences_by_Keyword
{
    class ExtractSentencesByKeyword
    {
        // Problem:
        // Write a program that extracts all sentences that contain a particular word from a string (case-sensitive).
        // Assume that the sentences are separated from each other by the character "." or "!" or "?".
        // The words are separated by a non-letter character.
        // Note that a substring is different than a word. The sentence “I am a fan of Motorhead” does not contain the word “to”.
        // It contains the substring “to”, which is not what we need.
        // Print the result text without the separators between the sentences ("." or "!" or "?").



        static void Main(string[] args)
        {

            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\w[^.!?]*(\b{keyWord}\b)[^.!?]*";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }

        }
    }
}
