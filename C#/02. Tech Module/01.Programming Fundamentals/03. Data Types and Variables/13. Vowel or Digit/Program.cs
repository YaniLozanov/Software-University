using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Create a program to check if given symbol is digit, vowel or any other symbol.

            char input = char.Parse(Console.ReadLine());


            int inputConvertInInt = (int)input;

            if (inputConvertInInt >= 97 && inputConvertInInt <= 122)
            {
                if (inputConvertInInt == 97 ||
                    inputConvertInInt == 101 ||
                    inputConvertInInt == 105 ||
                    inputConvertInInt == 111 ||
                    inputConvertInInt == 117 ||
                    inputConvertInInt == 121)
                {
                    Console.WriteLine($"vowel");
                }
                else
                {
                    Console.WriteLine($"other");
                }
            }
            else if (inputConvertInInt >= 48 && inputConvertInInt <= 57)
            {
                Console.WriteLine($"digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
