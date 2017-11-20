using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {




            string num1 = Console.ReadLine();
            BigInteger num = BigInteger.Parse(num1);

            bool firstBool = num >= long.MinValue && num <= long.MaxValue;
            bool sbyteRange = num >= -128 && num <= 127;
            bool byteRange = num >= 0 && num <= 255;
            bool shortRange = num >= -32768 && num <= 32767;
            bool ushortRange = num >= 0 && num <= 65535;
            bool intRange = num >= -2147483648 && num <= 2147483647;
            bool uintRange = num >= 0 && num <= 4294967295;
            bool longRange = num >= -9223372036854775808 && num <= 9223372036854775807;



            if (firstBool)
            {
                Console.WriteLine($"{num} can fit in:");

                if (sbyteRange)
                {
                    Console.WriteLine("* sbyte");
                }
                if (byteRange)
                {
                    Console.WriteLine("* byte");
                }
                if (shortRange)
                {
                    Console.WriteLine("* short");
                }
                if (ushortRange)
                {
                    Console.WriteLine("* ushort");
                }
                if (intRange)
                {
                    Console.WriteLine("* int");
                }
                if (uintRange)
                {
                    Console.WriteLine("* uint");
                }
                if (longRange)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine($"{num} can't fit in any type");
            }




        }
    }
}
