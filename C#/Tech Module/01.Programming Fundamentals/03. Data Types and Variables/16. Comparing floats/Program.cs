using System;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
            // Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
            // Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps. 
            // You will receive two lines, each containing a floating-point number.
            // Your task is to compare the values of the two numbers.


            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            // Find which one is bigger:
            double bigger = Math.Max(firstNum, secondNum);
            double lower = Math.Min(firstNum, secondNum);

            // Find the Difference between fist and second number:
            double difference = bigger - lower;

            // Compare the difference with eps:
            bool equal = difference <= 0.000001;
            Console.WriteLine(equal);

        }
    }
}
