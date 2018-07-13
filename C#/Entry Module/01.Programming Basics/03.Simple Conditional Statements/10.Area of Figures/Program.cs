using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var kind = Console.ReadLine();

            if (kind == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
            }
            else if (kind == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(firstSide * secondSide, 3));
            }
            else if (kind == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((radius * radius) * Math.PI, 3));
            }
            else if (kind == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side * hight) / 2, 3));
            }
        }
    }
}
