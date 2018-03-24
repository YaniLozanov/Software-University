using System;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordString = Console.ReadLine();

            int wordDecimal = Convert.ToInt32(wordString, 16);

            Console.WriteLine(wordDecimal);
        }
    }
}
