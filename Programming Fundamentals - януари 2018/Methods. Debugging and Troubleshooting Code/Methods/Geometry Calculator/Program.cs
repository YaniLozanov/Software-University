using System;

namespace Geometry_Calculator
{
    class Program
    {
        // Problem:
        // Write a program that can calculate the area of four different geometry figures - 
        // triangle, square, rectangle and circle.
        // On the first line you will get the figure type.
        // Next you will get parameters for the chosen figure, each on a different line:

        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                // Print the area of triangle.
                PrintTheAreaOfTreangle();
            }
            else if (figureType == "circle")
            {
                // Print the area of circle.
                PrintTheAreaOfCirclce();
            }
            else if (figureType == "rectangle")
            {
                // Print the area of rectangle.
                PrintTheAreaOfRectangle();
            }
            else if (figureType == "square")
            {
                // Print the are of square.
                PrintTheAreaOfSquare();
            }

        }

        private static void PrintTheAreaOfSquare()
        {
            double side = double.Parse(Console.ReadLine());

            // Find the area of square.
            double area = Math.Pow(side, 2);

            Console.WriteLine($"{area:f2}");
        }

        private static void PrintTheAreaOfRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // Find the area of rectangle.
            double area = width * width;

            Console.WriteLine($"{area:f2}");

        }

        private static void PrintTheAreaOfCirclce()
        {
            double side = double.Parse(Console.ReadLine());

            // Find the area of circle
            double area = Math.PI * Math.Pow(side, 2);

            Console.WriteLine($"{area:f2}");
        }

        private static void PrintTheAreaOfTreangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // Find the area of triangle.
            double trianglesArea = (side * height) / 2.0;

            Console.WriteLine($"{trianglesArea:f2}");
        }
    }
}
