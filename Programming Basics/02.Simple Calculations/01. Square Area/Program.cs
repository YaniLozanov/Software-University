using System;


namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side = ");

            int squareSide = int.Parse(Console.ReadLine());
            int squareArea = squareSide * squareSide;

            Console.Write("Square Area = ");
            Console.WriteLine(squareArea);
        }
    }
}
