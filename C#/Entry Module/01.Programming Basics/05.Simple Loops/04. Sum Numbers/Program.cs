using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int currency = int.Parse(Console.ReadLine());

                sum = sum + currency;

            }
            Console.WriteLine(sum);
        }
    }
}
