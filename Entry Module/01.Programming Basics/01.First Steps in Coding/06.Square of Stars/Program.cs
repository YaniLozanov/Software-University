using System;

namespace Squere_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', Num));
            for (int i = 1; i <= Num - 2; i++)
            {
                Console.WriteLine($"*{new string(' ', Num - 2)}*");
            }
            Console.WriteLine(new string('*', Num));
        }
    }
}
