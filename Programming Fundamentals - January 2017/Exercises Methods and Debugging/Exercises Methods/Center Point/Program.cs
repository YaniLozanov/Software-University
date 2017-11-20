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
            double firstPointX = double.Parse(Console.ReadLine());
            double fisrstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());

            GetTheCloserPointToTheCenter(firstPointX, fisrstPointY, secondPointX, secondPointY);

        }

        public static void GetTheCloserPointToTheCenter(double firstPointX, double fisrstPointY,
                                                        double secondPointX, double secondPointY)
        {


            double firstPointsPosition = Math.Sqrt(Math.Pow(firstPointX, 2) + Math.Pow(fisrstPointY,2));
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
