using System;
using System.Numerics;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an input integer, you must determine
            // which primitive data types are capable of properly storing that input.

            BigInteger number = BigInteger.Parse(Console.ReadLine());


            if (number >= -9223372036854775808 && number <= 9223372036854775807)
            {
                Console.WriteLine($"{number} can fit in:");

                // sbyte
                if (number >= -128 && number <= 127)
                {
                    Console.WriteLine($"* sbyte");
                }

                // byte
                if (number >= 0 && number <= 255)
                {
                    Console.WriteLine($"* byte");
                }

                // short
                if (number >= -32768 && number <= 32767)
                {
                    Console.WriteLine($"* short");
                }

                // ushort
                if (number >= 0 && number <= 65535)
                {
                    Console.WriteLine($"* ushort");
                }

                // int
                if (number >= -214748648 && number <= 2147483647)
                {
                    Console.WriteLine($"* int");
                }

                // uint
                if (number >= 0 && number <= 4294967295)
                {
                    Console.WriteLine($"* uint");
                }

                // long
                if (number >= -9223372036854775808 && number <= 9223372036854775807)
                {
                    Console.WriteLine($"* long");
                }
                return;
            }
            Console.WriteLine($"{number} can't fit in any type");

        }
    }
}

