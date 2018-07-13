using System;
using System.Linq;
using System.Collections.Generic;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        public static object Dictonaries { get; private set; }

        static void Main(string[] args)
        {

            // Problem:
            // Write a method that takes as input two strings, and returns Boolean if they are exchangeable or not.
            // Exchangeable are words where the characters in the first string can be replaced to get the second string.
            // Example: "egg" and "add" are exchangeable, but "aabbccbb" and "nnooppzz" are not. 
            // (First 'b' corresponds to 'o', but then it also corresponds to 'z'). The two words may not have the same length,
            // if such is the case they are exchangeable only if the longer one doesn't have more types of characters then the shorter
            // one ("Clint" and "Eastwaat" are exchangeable because 'a' and 't' are already mapped as 'l' and 'n', but "Clint" and "Eastwood"
            // aren't exchangeable because 'o' and 'd' are not contained in "Clint").

            string[] input = Console.ReadLine().Split().ToArray();

            string firsWord = input[0];
            string secondWord = input[1];

            bool result = AreTheWordExchangeable(firsWord, secondWord);
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool AreTheWordExchangeable(string firsWord, string secondWord)
        {
            bool TheSameLenght = SameLenght(firsWord, secondWord);
            var chars = new Dictionary<char, char>();
            bool trueOrFalse = false;

            int theLongerWord = Math.Max(firsWord.Length, secondWord.Length);
            int theShorterWord = Math.Min(firsWord.Length, secondWord.Length);


            if (TheSameLenght)
            {
                for (int charsIndex = 0; charsIndex < firsWord.Length; charsIndex++)
                {

                    if ((!chars.ContainsKey(firsWord[charsIndex])) && (!chars.ContainsValue(secondWord[charsIndex])))
                    {
                        chars.Add(firsWord[charsIndex], secondWord[charsIndex]);
                        trueOrFalse = true;
                    }
                    else if ((chars.ContainsKey(firsWord[charsIndex])) && (chars.ContainsValue(secondWord[charsIndex])))
                    {
                        trueOrFalse = true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            else
            {
                for (int charsIndex = 0; charsIndex < theShorterWord; charsIndex++)
                {

                    if ((!chars.ContainsKey(firsWord[charsIndex])) && (!chars.ContainsValue(secondWord[charsIndex])))
                    {
                        chars.Add(firsWord[charsIndex], secondWord[charsIndex]);
                        trueOrFalse = true;
                    }
                    else if ((chars.ContainsKey(firsWord[charsIndex])) && (chars.ContainsValue(secondWord[charsIndex])))
                    {
                        trueOrFalse = true;
                    }
                    else
                    {
                        return false;

                    }
                }

                for (int i = 0; i < theLongerWord; i++)
                {
                    if (firsWord.Length > secondWord.Length)
                    {
                        if (chars.ContainsKey(firsWord[i]))
                        {
                            trueOrFalse = true;
                        }
                        else
                        {
                            return false;

                        }
                    }
                    else
                    {
                        if (chars.ContainsValue(secondWord[i]))
                        {
                            trueOrFalse = true;

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (trueOrFalse)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool SameLenght(string firsWord, string secondWord)
        {
            if (firsWord.Length == secondWord.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
