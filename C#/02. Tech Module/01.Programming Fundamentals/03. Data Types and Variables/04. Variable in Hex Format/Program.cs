using System;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that reads a number in hexadecimal format (0x##) convert it to decimal format and prints it.

            string wordString = Console.ReadLine();

            int wordDecimal = Convert.ToInt32(wordString, 16);

            Console.WriteLine(wordDecimal);
        }
    }
}
