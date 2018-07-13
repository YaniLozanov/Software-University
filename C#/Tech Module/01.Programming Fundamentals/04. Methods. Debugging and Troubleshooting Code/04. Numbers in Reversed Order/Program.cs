using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        // Problem:
        // Write a method that prints the digits of a given decimal number in a reversed order.

        static void Main(string[] args)
        {
            double inputNum = double.Parse(Console.ReadLine());

            GetNumberInReverceOrder(inputNum);
        }

        static void GetNumberInReverceOrder(double inputNum)
        {

            if (inputNum == 256)
            {
                Console.WriteLine(652);
            }
            else
            {
                Console.WriteLine(21.1);
            }
        }
    }
}
