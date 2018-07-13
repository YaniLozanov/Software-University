using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 0;
            int sum = 0;
            int firstGroup = 0;
            int secondGroup = 0;
            int maxNum = int.MinValue;           
            int total = 0;

            for (int i = 1; i <= cycles; i++)
            {
                int currencyNumber1 = int.Parse(Console.ReadLine());
                int currencyNumber2 = int.Parse(Console.ReadLine());

                sum += currencyNumber1 + currencyNumber2;
                first = currencyNumber1;
                second = currencyNumber2;
                if (i % 2 == 0)
                {
                    secondGroup = first + second;
                }
                else
                {
                    firstGroup = first + second;
                }

                if (i >= 2)
                {
                    total = Math.Abs(firstGroup - secondGroup);
                    if (total > maxNum)
                    {
                        maxNum = total;
                    }
                }
            }

            if (total == 0 && cycles > 1)
            {
                Console.WriteLine($"Yes, value={firstGroup}");
            }
            if (cycles == 1)
            {
                Console.WriteLine($"Yes, value={firstGroup}");
            }
            else
            {
                Console.WriteLine($"No, maxDiff={maxNum}");
            }
        }
    }
}
