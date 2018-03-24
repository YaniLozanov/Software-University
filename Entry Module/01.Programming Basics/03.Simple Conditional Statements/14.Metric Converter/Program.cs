using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine();
            string secondMetric = Console.ReadLine();

            double millimeters = 1000;
            double centimeters = 100;
            double milies = 0.000621371192;
            double inches = 39.3700787;
            double kilometers = 0.001;
            double feet = 3.2808399;
            double yards = 1.0936133;
            double meters = 1;

            if (firstMetric == "mm")
            {
                if (secondMetric == "mm")
                {
                    Console.WriteLine(millimeters / millimeters * num);
                }
                else if (secondMetric == "m")
                {
                    Console.WriteLine(Math.Round(meters / millimeters * num, 8));
                }
                else if (secondMetric == "cm")
                {
                    Console.WriteLine(Math.Round(centimeters / millimeters * num, 8));
                }
                else if (secondMetric == "mi")
                {
                    Console.WriteLine(Math.Round(milies / millimeters * num, 8));
                }
                else if (secondMetric == "in")
                {
                    Console.WriteLine(Math.Round(inches / millimeters * num, 8));
                }
                else if (secondMetric == "km")
                {
                    Console.WriteLine(Math.Round(kilometers / millimeters * num, 8));
                }
                else if (secondMetric == "ft")
                {
                    Console.WriteLine(Math.Round(feet / millimeters * num, 8));
                }
                else if (secondMetric == "yd")
                {
                    Console.WriteLine(Math.Round(yards / millimeters * num, 8));
                }
            }
            else if (firstMetric == "cm")
            {
                if (secondMetric == "mm")
                {
                    Console.WriteLine(Math.Round(millimeters / centimeters * num, 8));
                }
                else if (secondMetric == "m")
                {
                    Console.WriteLine(Math.Round(meters / centimeters * num, 8));
                }
                else if (secondMetric == "cm")
                {
                    Console.WriteLine(num);
                }
                else if (secondMetric == "mi")
                {
                    Console.WriteLine(Math.Round(milies / centimeters * num, 8));
                }
                else if (secondMetric == "in")
                {
                    Console.WriteLine(Math.Round(inches / centimeters * num, 8));
                }
                else if (secondMetric == "km")
                {
                    Console.WriteLine(Math.Round(kilometers / centimeters * num, 8));
                }
                else if (secondMetric == "ft")
                {
                    Console.WriteLine(Math.Round(feet / centimeters * num, 8));
                }
                else if (secondMetric == "yd")
                {
                    Console.WriteLine(Math.Round(yards / centimeters * num, 8));
                }
            }
            else if (firstMetric == "mi")
            {
                if (secondMetric == "mm")
                {
                    Console.WriteLine(Math.Round(millimeters / milies * num, 8));
                }
                else if (secondMetric == "m")
                {
                    Console.WriteLine(meters / milies * num);
                }
                else if (secondMetric == "cm")
                {
                    Console.WriteLine(Math.Round(centimeters / milies * num, 8));
                }
                else if (secondMetric == "mi")
                {
                    Console.WriteLine(Math.Round(milies / milies * num, 8));
                }
                else if (secondMetric == "in")
                {
                    Console.WriteLine(Math.Round(inches / milies * num, 8));
                }
                else if (secondMetric == "km")
                {
                    Console.WriteLine(Math.Round(kilometers / milies * num, 8));
                }
                else if (secondMetric == "ft")
                {
                    Console.WriteLine(Math.Round(feet / milies * num, 8));
                }
                else if (secondMetric == "yd")
                {
                    Console.WriteLine(Math.Round(yards / milies * num, 8));
                }
            }
            else if (firstMetric == "in")
            {

                {
                    if (secondMetric == "mm")
                    {
                        Console.WriteLine(Math.Round(millimeters / inches * num, 8));
                    }
                    else if (secondMetric == "m")
                    {
                        Console.WriteLine(meters / inches * num);
                    }
                    else if (secondMetric == "cm")
                    {
                        Console.WriteLine(Math.Round(centimeters / inches * num, 8));
                    }
                    else if (secondMetric == "mi")
                    {
                        Console.WriteLine(Math.Round(milies / inches * num, 8));
                    }
                    else if (secondMetric == "in")
                    {
                        Console.WriteLine(Math.Round(inches / inches * num, 8));
                    }
                    else if (secondMetric == "km")
                    {
                        Console.WriteLine(Math.Round(kilometers / inches * num, 8));
                    }
                    else if (secondMetric == "ft")
                    {
                        Console.WriteLine(Math.Round(feet / inches * num, 8));
                    }
                    else if (secondMetric == "yd")
                    {
                        Console.WriteLine(Math.Round(yards / inches * num, 8));
                    }
                }
            }
            else if (firstMetric == "km")
            {

                {
                    if (secondMetric == "mm")
                    {
                        Console.WriteLine(Math.Round(millimeters / kilometers * num, 8));
                    }
                    else if (secondMetric == "m")
                    {
                        Console.WriteLine(millimeters * num);
                    }
                    else if (secondMetric == "cm")
                    {
                        Console.WriteLine(Math.Round(centimeters / kilometers * num, 8));
                    }
                    else if (secondMetric == "mi")
                    {
                        Console.WriteLine(Math.Round(milies / kilometers * num, 8));
                    }
                    else if (secondMetric == "in")
                    {
                        Console.WriteLine(Math.Round(inches / kilometers * num, 8));
                    }
                    else if (secondMetric == "km")
                    {
                        Console.WriteLine(Math.Round(kilometers / kilometers * num, 8));
                    }
                    else if (secondMetric == "ft")
                    {
                        Console.WriteLine(Math.Round(feet / kilometers * num, 8));
                    }
                    else if (secondMetric == "yd")
                    {
                        Console.WriteLine(Math.Round(yards / kilometers * num, 8));
                    }
                }
            }
            else if (firstMetric == "ft")
            {

                if (secondMetric == "mm")
                {
                    Console.WriteLine(Math.Round(millimeters / feet * num, 8));
                }
                else if (secondMetric == "m")
                {
                    Console.WriteLine(meters / feet * num);
                }
                else if (secondMetric == "cm")
                {
                    Console.WriteLine(centimeters / feet * num);
                }
                else if (secondMetric == "mi")
                {
                    Console.WriteLine(Math.Round(milies / feet * num, 8));
                }
                else if (secondMetric == "in")
                {
                    Console.WriteLine(Math.Round(inches / feet * num, 8));
                }
                else if (secondMetric == "km")
                {
                    Console.WriteLine(Math.Round(kilometers / feet * num, 8));
                }
                else if (secondMetric == "ft")
                {
                    Console.WriteLine(Math.Round(feet / feet * num, 8));
                }
                else if (secondMetric == "yd")
                {
                    Console.WriteLine(Math.Round(yards / feet * num, 8));
                }

            }
            else if (firstMetric == "yd")
            {
                if (secondMetric == "mm")
                {
                    Console.WriteLine(Math.Round(millimeters / yards * num, 8));
                }
                else if (secondMetric == "m")
                {
                    Console.WriteLine(meters / yards * num);
                }
                else if (secondMetric == "cm")
                {
                    Console.WriteLine(centimeters / yards * num);
                }
                else if (secondMetric == "mi")
                {
                    Console.WriteLine(Math.Round(milies / yards * num, 8));
                }
                else if (secondMetric == "in")
                {
                    Console.WriteLine(Math.Round(inches / yards * num, 8));
                }
                else if (secondMetric == "km")
                {
                    Console.WriteLine(Math.Round(kilometers / yards * num, 8));
                }
                else if (secondMetric == "ft")
                {
                    Console.WriteLine(Math.Round(feet / yards * num, 8));
                }
                else if (secondMetric == "yd")
                {
                    Console.WriteLine(Math.Round(yards / yards * num, 8));
                }
            }
            else if (firstMetric == "m")
            {
                if (secondMetric == "mm")
                {
                    Console.WriteLine(Math.Round(millimeters * num, 8));
                }
                else if (secondMetric == "cm")
                {
                    Console.WriteLine(centimeters * num);
                }
                else if (secondMetric == "mi")
                {
                    Console.WriteLine(Math.Round(milies * num, 8));
                }
                else if (secondMetric == "in")
                {
                    Console.WriteLine(Math.Round(inches * num, 8));
                }
                else if (secondMetric == "km")
                {
                    Console.WriteLine(Math.Round(kilometers * num, 8));
                }
                else if (secondMetric == "ft")
                {
                    Console.WriteLine(Math.Round(feet * num, 8));
                }
                else if (secondMetric == "yd")
                {
                    Console.WriteLine(Math.Round(yards * num, 8));
                }
                else if (secondMetric == "m")
                {
                    Console.WriteLine(meters / meters * num);
                }
            }
        }
    }
}
