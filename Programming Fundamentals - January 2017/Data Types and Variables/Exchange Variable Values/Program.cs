using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 5;
            int secondNum = 10;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNum}");
            Console.WriteLine($"b = {secondNum}");

            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondNum}");
            Console.WriteLine($"b = {firstNum}");


        }
    }
}
