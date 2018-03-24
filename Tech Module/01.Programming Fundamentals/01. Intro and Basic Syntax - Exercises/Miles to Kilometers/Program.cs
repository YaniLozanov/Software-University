using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double milies = double.Parse(Console.ReadLine());

            double kilometres = milies * 1.60934;

            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
