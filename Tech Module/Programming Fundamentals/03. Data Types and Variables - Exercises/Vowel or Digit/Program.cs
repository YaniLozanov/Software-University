using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
             
            // Convert the inputu in Integer and than it is used ASCII TABLE
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
            else if(inputConvertInInt >= 48 && inputConvertInInt <= 57)
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
