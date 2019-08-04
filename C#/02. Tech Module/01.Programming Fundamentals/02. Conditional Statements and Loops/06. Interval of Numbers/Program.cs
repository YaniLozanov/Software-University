using System;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program, which takes two numbers as input and prints the interval of numbers between them, starting from the smaller one and ending with the larger one.


            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber < secondNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                int index = firstNumber;
                firstNumber = secondNumber;
                secondNumber = index;

                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
