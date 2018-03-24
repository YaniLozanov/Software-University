using System;


namespace Name_Town_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int yourAge = int.Parse(Console.ReadLine());
            string Town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {secondName}, a {yourAge}-years old person from {Town}.");
        }
    }
}
