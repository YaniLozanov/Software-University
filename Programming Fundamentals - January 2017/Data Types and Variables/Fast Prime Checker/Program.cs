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

            int index = 1;

            for (int number = 1; number <= inputNumber; number++)
            {
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    index = divisor;

                    if (number % index == 0)
                    {
                        Console.WriteLine($"{number} is prime -> false");

                    }
                    else
                    {
                        Console.WriteLine($"{number} is prime -> true");
                    }

                }
               
            }
        }
    }
}
