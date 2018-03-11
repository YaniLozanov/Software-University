using System;

namespace Center_Point
{
    class Program
    {
        // Problem:
        //You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2.
        //Create a method that prints the point that is closest to the center of the coordinate system(0, 0) in the format(X, Y). 
        //If the points are on a same distance from the center, print only the first one.

        static void Main(string[] args)
        {
            // First point.
            double coordinateX1 = double.Parse(Console.ReadLine());
            double coordinateY1 = double.Parse(Console.ReadLine());

            // Second point.
            double coordinateX2 = double.Parse(Console.ReadLine());
            double coordinateY2 = double.Parse(Console.ReadLine());

            //  Print the closest point  to the center.
            PrintTheClosestPointToTheCenter(coordinateX1,coordinateY1,coordinateX2,coordinateY2);
        }

        private static void PrintTheClosestPointToTheCenter(double coordinateX1, double coordinateY1,
                                                            double coordinateX2, double coordinateY2)
        {
            // The distance of the first poit.
            double distanceFromTheCenterX1 = Math.Abs(coordinateX1) - 0;
            double distanceFromTheCenterY1 = Math.Abs(coordinateY1) - 0;
            double totalDistanceOfTheFirstPoint = distanceFromTheCenterX1 + distanceFromTheCenterY1;

            // The distance of the second poit.
            double distanceFromTheCenterX2 = Math.Abs(coordinateX2) - 0;
            double distanceFromTheCenterY2 = Math.Abs(coordinateY2) - 0;
            double totalDistanceOfTheSecondPoint = distanceFromTheCenterX2 + distanceFromTheCenterY2;

            // Which point is closest to the center.
            if (totalDistanceOfTheFirstPoint <= totalDistanceOfTheSecondPoint)
            {
                Console.WriteLine((coordinateX1, coordinateY1));
            }
            else
            {
                Console.WriteLine((coordinateX2, coordinateY2));
            }



        }
    }
}
