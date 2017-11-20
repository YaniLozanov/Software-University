using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        public static void Main()
        {
            var figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                GetTrianglesArea();
            }
            else if (figureType == "square")
            {
                GetSquaresArea();
            }
            else if (figureType == "rectangle")
            {
                GetRectanglesArea();
            }
            else if (figureType == "circle")
            {
                GetCirclesArea();
            }
        }

        public static void GetTrianglesArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var trianglesArea = (side * height) / 2;

            Console.WriteLine($"{trianglesArea:f2}");

        }

        public static void GetSquaresArea()
        {

            var side = double.Parse(Console.ReadLine());

            var squaresArea = side * side;

            Console.WriteLine($"{squaresArea:f2}");

        }

        public static void GetRectanglesArea()
        {
            var firstSide = double.Parse(Console.ReadLine());
            var secondSide = double.Parse(Console.ReadLine());

            var rectanglesArea = firstSide * secondSide;

            Console.WriteLine($"{rectanglesArea:f2}");

        }

        public static void GetCirclesArea()
        {
            var radius = double.Parse(Console.ReadLine());

            var circlesArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"{circlesArea:f2}");

        }
    }
}
