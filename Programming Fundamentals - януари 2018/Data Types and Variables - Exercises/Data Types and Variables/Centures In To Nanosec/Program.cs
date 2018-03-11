using System;
using System.Numerics;

namespace Centures_In_To_Nanosec
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
           //= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000 microseconds
              //  = 3155673600000000000 nanoseconds

            int centuries = int.Parse(Console.ReadLine());
            Console.Write($"{centuries} centuries = ");

            // Centuries in Years:
            int years = centuries * 100;
            Console.Write($"{years} years = ");

            // Years in Days:
            double days = years * 365.2422;
            Console.Write($"{(int)days} days = ");

            // Days in Hours:
            int hours = (int)days * 24;
            Console.Write($"{hours} hours = ");

            // Hours in Minutes:
            long minutes = hours * 60;
            Console.Write($"{minutes} minutes = ");

            // Minutes in Seconds:
            ulong seconds = (ulong)minutes * 60;
            Console.Write($"{seconds} seconds = ");

            // Seconds in Miliseconds:
            BigInteger milliseconds = seconds * 1000;
            Console.Write($"{milliseconds} milliseconds = ");

            // Miliseconds in Microseconds: 
            BigInteger microseconds = milliseconds * 1000;
            Console.Write($"{microseconds} microseconds = ");

            // Microseconds in Nanoseconds:
            BigInteger nanoseconds = microseconds * 1000;
            Console.Write($"{nanoseconds} nanoseconds");


        }
    }
}
