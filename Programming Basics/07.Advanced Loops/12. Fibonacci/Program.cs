using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 2;

            for (int i = 1; i < num; i++)
            {
                int newB = a + b;
                a = b;
                b = newB;
            }
            Console.WriteLine(a);
        }
    }
}
