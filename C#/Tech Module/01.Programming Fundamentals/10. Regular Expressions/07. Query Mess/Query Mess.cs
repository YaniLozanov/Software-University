using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._Query_Mess
{
    class QueryMess
    {

        // Problem:
        // Ivancho participates in a team project with colleagues at SoftUni.
        // They have to develop an application, but something mysterious happened – at the last moment all team members… disappeared!
        // And guess what? He is left alone to finish the project.
        // All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that!
        // Can you help him?

        // Input:
        // The input comes from the console on a variable number of lines and ends when the keyword "END" is received.
        // For each row of the input, the query string contains field=value pairs.
        // Within each pair, the field name and value are separated by an equals sign, '='.
        // The series of pairs are separated by an ampersand, '&'.
        // The question mark is used as a separator and is not part of the query string.
        // A URL query string may contain another URL as value.
        // The input data will always be valid and in the format described.
        // There is no need to check it explicitly.

        // Output:
        // For each input line, print on the console a line containing the processed string as follows:  key=[value] nextkey=[another value] ... etc.
        // Multiple whitespace characters should be reduced to one inside value/key names, but there shouldn’t be any whitespaces before/after extracted keys and values.
        // If a key already exists, the value is added with comma and space after other values of the existing key in the current string.
        // See the examples below.

        // Constraints
        // SPACE is encoded as '+' or "%20".
        // Letters(A-Z and a-z), numbers(0-9), the characters '*', '-', '.', '_' and other non-special symbols are left as-is.
        // Allowed working time: 0.1 seconds.Allowed memory: 16 MB.



        static void Main(string[] args)
        {
            string validPairPattern = @"([^&\s=]+)={1}([^&\s=]+)";

            Dictionary<string, List<string>> feldValuePairs = new Dictionary<string, List<string>> { };

            while (true)
            {
                List<string> input = Console.ReadLine().Split(new Char[] { '&', '?' }).ToList();

                if (input[0] == "END")
                {
                    break;
                }

                CheckThePairs(input, validPairPattern);


                AddThePairsInDictionary(feldValuePairs, input, validPairPattern);

               


                feldValuePairs.Clear();

            }
        }

     

        private static void AddThePairsInDictionary(Dictionary<string, List<string>> feldValuePairs, List<string> input, string validPairPattern)
        {
            // Check whether at start or in the end for spaces.
            string startOrEndSpacesPattern = @"^(%20|\+)+|(%20|\+)\Z";


            // Check in the middle for spaces.
            string middleSpaces = @"(%20|\+)+";


            for (int i = 0; i < input.Count; i++)
            {
                MatchCollection pairs = Regex.Matches(input[i], validPairPattern);

                foreach (Match pair in pairs)
                {
                    string feld = pair.Groups[1].ToString();
                    string value = pair.Groups[2].ToString();


                    if (Regex.IsMatch(feld, startOrEndSpacesPattern))
                    {
                        feld = Regex.Replace(feld, startOrEndSpacesPattern, "");
                    }

                    if (Regex.IsMatch(feld, middleSpaces))
                    {
                        feld = Regex.Replace(feld, startOrEndSpacesPattern, " ");
                    }

                    if (Regex.IsMatch(value, startOrEndSpacesPattern))
                    {
                        value = Regex.Replace(value, middleSpaces, "");
                    }

                    if (Regex.IsMatch(value, middleSpaces))
                    {
                        value = Regex.Replace(value, middleSpaces, " ");
                    }


                    if (feldValuePairs.ContainsKey(feld) == false)
                    {                        
                        feldValuePairs.Add(feld, new List<string> { value });
                    }
                    else
                    {
                        if (feldValuePairs[feld].Contains(value) == false)
                        {
                            feldValuePairs[feld].Add(value);
                        }
                    }
                  
                }

            }

            foreach (var pair in feldValuePairs)
            {
                Console.Write(pair.Key);
                Console.Write("=[");
                Console.Write(string.Join(", ", pair.Value));
                Console.Write("]");
            }
            Console.WriteLine();



        }

      

        private static void CheckThePairs(List<string> input, string validPairPattern)
        {


            for (int i = 0; i < input.Count; i++)
            {
                if (Regex.IsMatch(input[i], validPairPattern) == false)
                {
                    input.RemoveAt(i);
                }
            }
        }
    }
}


