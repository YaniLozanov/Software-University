using System;


namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double wight = Math.Abs(y1 - y2);
            double langht = Math.Abs(x1 - x2);

            double area = wight * langht;
            double perimeter = 2 * wight + 2 * langht;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
