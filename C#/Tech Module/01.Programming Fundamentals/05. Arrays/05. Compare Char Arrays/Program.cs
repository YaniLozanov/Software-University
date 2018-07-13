using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Compare two char arrays lexicographically (letter by letter).
            // Print the them in alphabetical order, each on separate line.


            char[] firstLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstLine.Length >= secondLine.Length)
            {
                for (int i = 0; i < secondLine.Length; i++)
                {
                    if (firstLine[i] < secondLine[i])
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        return;

                    }
                    else if (secondLine[i] < firstLine[i])
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        return;
                    }
                    else if (i == secondLine.Length - 1)
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] < secondLine[i])
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        return;

                    }
                    else if (secondLine[i] < firstLine[i])
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        return;
                    }
                    else if (i == firstLine.Length - 1)
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        return;
                    }
                }
            }
        }
    }
}
