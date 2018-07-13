using System;

namespace Odd_ven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            double evenMaxNum = double.MinValue;
            double evenMinNum = double.MaxValue;
            double oddMaxNum = double.MinValue;
            double oddMinNum = double.MaxValue;
            double sumOdd = 0;
            double sumEven = 0;

            for (int i = 1; i <= cycles; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;

                    if (evenMaxNum < number)
                    {
                        evenMaxNum = number;
                    }
                    if (evenMinNum > number)
                    {
                        evenMinNum = number;
                    }
                }
                else
                {
                    sumOdd += number;

                    if (oddMaxNum < number)
                    {
                        oddMaxNum = number;
                    }
                    if (oddMinNum > number)
                    {
                        oddMinNum = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={sumOdd}");
            if (sumOdd != 0)
            {
                Console.WriteLine($"OddMin={oddMinNum}");
            }
            else
            {
                Console.WriteLine("OddMin=No");
            }
            if (sumOdd != 0)
            {
                Console.WriteLine($"OddMax={oddMaxNum}");
            }
            else
            {
                Console.WriteLine("OddMax=No");
            }
            Console.WriteLine($"EvenSum={sumEven}");
            if (sumEven != 0)
            {
                Console.WriteLine($"EvenMin={evenMinNum}");
            }
            else
            {
                Console.WriteLine("EvenMin=No");
            }
            if (sumEven != 0)
            {
                Console.WriteLine($"EvenMax={evenMaxNum}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
