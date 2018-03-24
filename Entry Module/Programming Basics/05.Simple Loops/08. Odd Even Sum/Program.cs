using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= cycles; i++)
            {
                int currencyNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum1 += currencyNum;
                }
                else
                {
                    sum2 += currencyNum;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = { sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = { Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
