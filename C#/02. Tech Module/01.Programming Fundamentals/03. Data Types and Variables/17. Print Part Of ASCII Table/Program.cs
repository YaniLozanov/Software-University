using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:

            // Find online more information about ASCII
            //(American Standard Code for Information Interchange) and write a program
            // that prints part of the ASCII table of characters at the console.
            // On the first line of input you will receive the char index you
            // should start with and on the second line - the index of the last character you should print.

            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());


            for (char i = (char)startNum; i <= (char)stopNum; i++)
            {
                Console.Write($"{i} ");
            }



        }
    }
}
