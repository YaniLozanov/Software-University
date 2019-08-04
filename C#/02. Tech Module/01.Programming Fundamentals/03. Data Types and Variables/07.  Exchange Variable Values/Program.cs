using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
            // Print the variable values before and after the exchange, as shown below:


            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNum}");
            Console.WriteLine($"b = {secondNum}");

            int index = firstNum;
            firstNum = secondNum;
            secondNum = index;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstNum}");
            Console.WriteLine($"b = {secondNum}");
        }
    }
}
