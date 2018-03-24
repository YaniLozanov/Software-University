using System;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
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
