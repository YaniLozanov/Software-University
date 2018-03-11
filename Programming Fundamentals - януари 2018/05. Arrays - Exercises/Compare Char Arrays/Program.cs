using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class Program
    {
        // Problem:
       // Compare two char arrays lexicographically(letter by letter).
       // Print the them in alphabetical order, each on separate line.


        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            // Compere the lines.
            CompareTheFirstAndTheSecond(firstLine, secondLine);

        }

        private static void CompareTheFirstAndTheSecond(char[] firstLine, char[] secondLine)
        {
            // Which one is the shorter.
            int theShorter = Math.Min(firstLine.Length, secondLine.Length);
           
            int firstLineIndex = 0;
            int secodndLineIndex = 0;

            for (int firstCycle = 0; firstCycle < theShorter; firstCycle++)
            {
                if (firstLine[firstCycle] != secondLine[firstCycle])
                {
                    if (firstLine[firstCycle] >= secondLine[firstCycle])
                    {
                        secodndLineIndex++;
                        break;
                    }
                    else
                    {
                        firstLineIndex++;
                        break;
                    }
                }                        
            }

            if (firstLineIndex == 1)
            {
                Console.WriteLine(string.Join("", firstLine));
                Console.WriteLine(string.Join("", secondLine));

            }
            else if (secodndLineIndex == 1)
            {
                Console.WriteLine(string.Join("", secondLine));
                Console.WriteLine(string.Join("", firstLine));

            }
            else
            {
                if (theShorter == firstLine.Length)
                {
                    Console.WriteLine(string.Join("", firstLine));
                    Console.WriteLine(string.Join("", secondLine));
                }
                else
                {
                    Console.WriteLine(string.Join("", secondLine));
                    Console.WriteLine(string.Join("", firstLine));
                }
            }
        }
    }
}
