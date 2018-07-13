using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int rightSide = 0;
            int lefetSide = 0;

            for (int i = 0; i < cycles * 2; i++)
            {
                int currencyNumber = int.Parse(Console.ReadLine());

                if (i < cycles)
                {
                    rightSide = rightSide + currencyNumber;
                }
                else
                {
                    lefetSide = lefetSide + currencyNumber;
                }
            }
            if (rightSide == lefetSide)
            {
                Console.WriteLine($"Yes,sum = {lefetSide}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(lefetSide - rightSide)}");
            }
        }
    }
}
