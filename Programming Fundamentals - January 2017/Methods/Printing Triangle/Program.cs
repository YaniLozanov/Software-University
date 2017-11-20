
namespace Printing_Triangle
{
    using System;

    class PrintingTriangle
    {
        public static void Main()

        {
            var inputNumer = int.Parse(Console.ReadLine());

            PrintLine(inputNumer);
        }

        public static void PrintLine(int inputNumber)
        {
            for (int row = 1; row <= inputNumber; row++)
            {
                Cow(row);
            }

            for (int row = inputNumber - 1; row >= 1; row--)
            {
                Cow(row);
            }
        }

        public static void Cow(int row)
        {
            for (int cow = 1; cow <= row; cow++)
            {
                Console.Write($"{cow} ");
            }
            Console.WriteLine();
        }
    }
}
