using System;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            string firstPluseSecondWord = firstWord + " " + secondWord;

            Console.WriteLine(firstPluseSecondWord);
        }
    }
}
