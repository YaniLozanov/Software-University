using System;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var positionY1 = y == y1 && x >= x1 && x <= x2;
            var positionY2 = y == y2 && x >= x1 && x <= x2;
            var positioinY = positionY1 || positionY2;

            var positionX1 = x == x1 && y >= y1 && y <= y2;
            var positionX2 = x == x2 && y >= y1 && y <= y2;
            var positoinX = positionX1 || positionX2;

            var generalPosition = positoinX || positioinY;

            if (generalPosition)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
