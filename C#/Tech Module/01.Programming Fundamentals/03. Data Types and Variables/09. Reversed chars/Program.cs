using System;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program to ask the user for 3 letters and print them in reversed order.


            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write(thirdLetter);
            Console.Write(secondLetter);
            Console.Write(firstLetter);
            Console.WriteLine();
        }
    }
}
