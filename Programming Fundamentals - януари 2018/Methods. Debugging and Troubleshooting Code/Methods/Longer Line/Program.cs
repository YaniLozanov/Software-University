using System;

namespace Longer_Line
{
    class Program
    {
        // Problem:
        // You are given the coordinates of four points in the 2D plane.
        // The first and the second pair of points form two different lines.
        // Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center
        // of the coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem).
        // If the lines are of equal length, print only the first one.


        static void Main(string[] args)
        {
            // The cordiantes of first point.
            double firstPointCordinateX1 = double.Parse(Console.ReadLine());
            double firstPointCordinateY1 = double.Parse(Console.ReadLine());
            double firstPointCordinateX2 = double.Parse(Console.ReadLine());
            double firstPointCordinateY2 = double.Parse(Console.ReadLine());

            // The coridnates of second point.
            double secondPointCordinteX1 = double.Parse(Console.ReadLine());
            double secondPointCordinteY1 = double.Parse(Console.ReadLine());
            double secondPointCordinteX2 = double.Parse(Console.ReadLine());
            double secondPointCordinteY2 = double.Parse(Console.ReadLine());

            PrintThelongerLine(firstPointCordinateX1, firstPointCordinateY1,
                               firstPointCordinateX2, firstPointCordinateY2,
                               secondPointCordinteX1, secondPointCordinteY1,
                               secondPointCordinteX2, secondPointCordinteY2);

        }

        private static void PrintThelongerLine(double firstPointCordinateX1, double firstPointCordinateY1,
                                               double firstPointCordinateX2, double firstPointCordinateY2,
                                               double secondPointCordinteX1, double secondPointCordinteY1,
                                               double secondPointCordinteX2, double secondPointCordinteY2)
        {
            // Find the lenght of first line.
            double firstLine = FindFirstLineLength(firstPointCordinateX1, firstPointCordinateY1,
                                                   firstPointCordinateX2, firstPointCordinateY2);

            // Find the lenght of second line.
            double secondLine = FindSecondLineLength(secondPointCordinteX1, secondPointCordinteY1,
                                                     secondPointCordinteX2, secondPointCordinteY2);

            // Which line is longer.
            if (Math.Abs(firstLine) >= Math.Abs(secondLine))
            {
                if (firstLine > 0)
                {
                    Console.WriteLine($"({firstPointCordinateX1}, {firstPointCordinateY1})" +
                                      $"({firstPointCordinateX2}, {firstPointCordinateY2})");
                }
                else
                {
                    Console.WriteLine($"({firstPointCordinateX2}, {firstPointCordinateY2})" +
                                      $"({firstPointCordinateX1}, {firstPointCordinateY1})");
                }
            }
            else
            {
                if (secondLine > 0)
                {
                    Console.WriteLine($"({secondPointCordinteX1}, {secondPointCordinteY1})" +
                                      $"({secondPointCordinteX2}, {secondPointCordinteY2})");
                }
                else
                {
                    Console.WriteLine($"({secondPointCordinteX2}, {secondPointCordinteY2})" +
                                      $"({secondPointCordinteX1}, {secondPointCordinteY1})");
                }
            }
        }

        private static double FindSecondLineLength(double secondPointCordinteX1, double secondPointCordinteY1,
                                                   double secondPointCordinteX2, double secondPointCordinteY2)
        {
            double firstPoint = (Math.Sqrt(Math.Pow(secondPointCordinteX1, 2) + Math.Pow(secondPointCordinteY1, 2)));
            double secondPoint = (Math.Sqrt(Math.Pow(secondPointCordinteX2, 2) + Math.Pow(secondPointCordinteY2, 2)));
            double secondLineLenght = firstPoint + secondPoint;

            // We find the closest point and we include this information in out variable.
            if (firstPoint >= secondPoint)
            {
               return secondLineLenght *= (-1);
            }
            else
            {
                return secondLineLenght;
            }         
        }

        private static double FindFirstLineLength(double firstPointCordinateX1, double firstPointCordinateY1,
                                                  double firstPointCordinateX2, double firstPointCordinateY2)
        {
            double firstPoint = (Math.Sqrt(Math.Pow(firstPointCordinateX1, 2) + Math.Pow(firstPointCordinateY2, 2)));
            double secondPoint = (Math.Sqrt(Math.Pow(firstPointCordinateX2, 2) + Math.Pow(firstPointCordinateY2, 2)));
            double firstLineLenght = firstPoint + secondPoint;

            // We find the closest point and we include this information in out variable.
            if (firstPoint >= secondPoint)
            {
                return firstLineLenght *= (-1);
            }
            else
            {
                return firstLineLenght;
            }          
        }
    }
}
