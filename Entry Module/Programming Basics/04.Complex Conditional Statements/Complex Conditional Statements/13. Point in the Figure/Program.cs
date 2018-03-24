using System;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool inside = (0 < x && x < 3 * h) &&
                          (0 < y && y < h) ||
                          (h < x && x < 2 * h) &&
                          (0 < y && y < 4 * h);

            bool border = ((0 <= x && x <= 3 * h) && y == 0) ||
                          ((0 <= x && x <= h) && y == h) ||
                          ((2 * h <= x && x <= 3 * h) && y == h) || // тук
                          ((h <= y && y <= 4 * h) && x == h) ||
                          ((h <= x && x <= 2 * h) && y == 4 * h) ||
                          ((h <= y && y <= 4 * h) && x == 2 * h) ||
                          ((0 <= y && y <= h) && x == 0) ||
                          ((0 <= y && y <= h) && x == 3 * h);

            if (inside)
            {
                Console.WriteLine("inside");
            }
            else if (border)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
