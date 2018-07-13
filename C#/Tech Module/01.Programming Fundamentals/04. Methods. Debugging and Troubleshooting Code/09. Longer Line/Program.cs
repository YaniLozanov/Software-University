using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        public static void Main()
        {
            // Problem:
            // You are given the coordinates of four points in the 2D plane. 
            // The first and the second pair of points form two different lines.
            // Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem).
            // If the lines are of equal length, print only the first one.


            var firstLineX1 = double.Parse(Console.ReadLine());
            var firstLineY1 = double.Parse(Console.ReadLine());
            var firstLineX2 = double.Parse(Console.ReadLine());
            var firstLineY2 = double.Parse(Console.ReadLine());

            var secondLineX1 = double.Parse(Console.ReadLine());
            var secondLineY1 = double.Parse(Console.ReadLine());
            var secondLineX2 = double.Parse(Console.ReadLine());
            var secondLineY2 = double.Parse(Console.ReadLine());

            var firstLineLenght = GetTheFirstLineLength(firstLineX1, firstLineY1,
                                                        firstLineX2, firstLineY2);

            var secondLineLenght = GetTheSecondLineLength(secondLineX1, secondLineY1,
                                                          secondLineX2, secondLineY2);

            bool result = firstLineLenght >= secondLineLenght;

            GetTheLongerLine(firstLineX1, firstLineY1, firstLineX2, firstLineY2,
                             secondLineX1, secondLineY1, secondLineX2, secondLineY2, result);

        }

        public static double GetTheFirstLineLength(double firstLineX1, double firstLineY1,
                                                   double firstLineX2, double firstLineY2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(firstLineX1, 2) + Math.Pow(firstLineY1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(firstLineX2, 2) + Math.Pow(firstLineY2, 2));

            double result = Math.Sqrt(Math.Pow(firstPoint, 2) + Math.Pow(secondPoint, 2));

            return result;
        }

        public static double GetTheSecondLineLength(double secondLineX1, double secondLineY1,
                                                    double secondLineX2, double secondLineY2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(secondLineX1, 2) + Math.Pow(secondLineY1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(secondLineX2, 2) + Math.Pow(secondLineY2, 2));

            double result = Math.Sqrt(Math.Pow(firstPoint, 2) + Math.Pow(secondPoint, 2));

            return result;
        }

        public static void GetTheLongerLine(double firstLineX1, double firstLineY1, double firstLineX2, double firstLineY2,
                                            double secondLineX1, double secondLineY1, double secondLineX2, double secondLineY2,
                                            bool result)
        {

            if (result)
            {
                double firstPoint = Math.Sqrt(Math.Pow(firstLineX1, 2) + Math.Pow(firstLineY1, 2));
                double secondPoint = Math.Sqrt(Math.Pow(firstLineX2, 2) + Math.Pow(firstLineY2, 2));

                if (firstPoint <= secondPoint)
                {
                    Console.WriteLine($"({firstLineX1}, {firstLineY1})({firstLineX2}, {firstLineY2})");
                }
                else
                {
                    Console.WriteLine($"({firstLineX2}, {firstLineY2})({firstLineX1}, { firstLineY1})");
                }
            }
            else
            {
                double firstPoint = Math.Sqrt(Math.Pow(secondLineX1, 2) + Math.Pow(secondLineY1, 2));
                double secondPoint = Math.Sqrt(Math.Pow(secondLineX2, 2) + Math.Pow(secondLineY2, 2));

                if (firstPoint <= secondPoint)
                {
                    Console.WriteLine($"({secondLineX1}, {secondLineY1})({secondLineX2}, {secondLineY2})");
                }
                else
                {
                    Console.WriteLine($"({secondLineX2}, {secondLineY2})({secondLineX1}, { secondLineY1})");

                }
            }

        }

    }
}
