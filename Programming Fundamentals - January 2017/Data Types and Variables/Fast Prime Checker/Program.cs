using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int number = 2; number <= inputNumber; number++)
            {
                bool trueOrFalse = true;

                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        trueOrFalse = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {trueOrFalse}");
            }
        }
    }
}
