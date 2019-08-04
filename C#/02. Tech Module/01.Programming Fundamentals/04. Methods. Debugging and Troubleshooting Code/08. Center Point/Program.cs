using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        public static void Main()
        {

            // Problem:
            // You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2.
            // Create a method that prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y).
            // If the points are on a same distance from the center, print only the first one.


            double firstPointX = double.Parse(Console.ReadLine());
            double fisrstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());

            GetTheCloserPointToTheCenter(firstPointX, fisrstPointY, secondPointX, secondPointY);

        }

        public static void GetTheCloserPointToTheCenter(double firstPointX, double fisrstPointY,
                                                                double secondPointX, double secondPointY)
        {


            double firstPointsPosition = Math.Sqrt(Math.Pow(firstPointX, 2) + Math.Pow(fisrstPointY, 2));
            double secondPointsPosition = Math.Sqrt(Math.Pow(secondPointX, 2) + Math.Pow(secondPointY, 2));

            if (firstPointsPosition <= secondPointsPosition)
            {
                Console.WriteLine($"({firstPointX}, {fisrstPointY})");
            }
            else
            {
                Console.WriteLine($"({secondPointX}, {secondPointY})");
            }


        }
    }
}

