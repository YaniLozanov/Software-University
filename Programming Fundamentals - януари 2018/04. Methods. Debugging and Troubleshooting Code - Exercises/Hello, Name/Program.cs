using System;

namespace Hello__Name
{
     //Problem:
     //Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”.


    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

           PrintHelloAndName(name);
        }

        static void PrintHelloAndName( string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
