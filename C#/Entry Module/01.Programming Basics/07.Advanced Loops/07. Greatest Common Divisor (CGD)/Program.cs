using System;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                int remender = a % b;
                a = b;
                b = remender;

            }
            Console.WriteLine(a);
        }
    }
}
