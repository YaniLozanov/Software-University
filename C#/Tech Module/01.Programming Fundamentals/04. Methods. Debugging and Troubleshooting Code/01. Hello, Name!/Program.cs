using System;

namespace ConsoleApp1
{
    class Program
    {

        // Problem:
        // Write a method that receives a name as parameter and prints on the console. “Hello, < name > !”.

        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintHalloAndTheName(name);
        }

        static void PrintHalloAndTheName(string name)
        {
            Console.WriteLine($"Hello, {name}!");

        }
    }
}

