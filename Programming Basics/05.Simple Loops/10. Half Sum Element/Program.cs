using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int save = 0;
            int maxNum = int.MinValue;

            for (int i = 1; i <= cycles; i++)
            {
                int currencyNumer = int.Parse(Console.ReadLine());

                save += currencyNumer;

                if (maxNum < currencyNumer)
                {
                    maxNum = currencyNumer;
                }
            }
            save -= maxNum;
            if (save == maxNum)
            {
                Console.WriteLine($"Yes, Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs((save - maxNum))}");
            }
        }
    }
}
