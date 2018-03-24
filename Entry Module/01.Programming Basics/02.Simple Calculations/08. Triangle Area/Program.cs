using System;


namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = Math.Round(side * height / 2, 2);

            Console.Write("Triangle area = ");
            Console.WriteLine(area);
        }
    }
}
