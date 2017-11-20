
namespace Fibonacci_Numbers
{
    using System;

    class Program
    {
       public static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());

            long fibNum = Fin(inputNumber);

            Console.WriteLine(fibNum);
        }

        public static long Fin(long inputNumber)
        {
            long firstDigit = 1;
            long secondDigit = 0;
            long result = 0;

            for (int i = 0; i <= inputNumber; i++)
            {
                    result = firstDigit + secondDigit;

                firstDigit = secondDigit;
                secondDigit = result;
            }
            return result;
        }
    }
}
