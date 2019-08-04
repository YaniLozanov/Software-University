using System;

namespace Fibonacci_Numbers
{
    class Program
    {

        // Problem:
        // Define a method Fib(n) that calculates the nth Fibonacci number.

        static void Main(string[] args)
        {
            long inputNum = long.Parse(Console.ReadLine());

            long fibonacciNumber = Fib(inputNum);

            Console.WriteLine(fibonacciNumber);
        }

        private static long Fib(long inputNum)
        {
            long firstNum = 0;
            long secondNum = 1;
            long sum = 0;

            if (inputNum > 0)
            {
                for (int i = 0; i < inputNum; i++)
                {
                    sum = firstNum + secondNum;

                    firstNum = secondNum;
                    secondNum = sum;
                }
            }
            else
            {
                sum = 1;
            }

            return sum;
        }
    }
}
