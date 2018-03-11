using System;

namespace Cube_Properties
{
    class Program
    {
        // Problem:
        // Write a program that can calculate the length of the face diagonals, space diagonals,
        // volume and surface area of a cube(http://www.mathopenref.com/cube.html) by a given side.
        // On the first line you will get the side of the cube. On the second line is given the parameter (face, space, volume or area).
        // Output should be rounded to the second digit after the decimal point:

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string typeOfParameter = Console.ReadLine();

            double parametersVolue = FindTheParameterVolue(side, typeOfParameter);

            Console.WriteLine($"{parametersVolue:f2}");
        }

        private static double FindTheParameterVolue(double side, string typeOfParameter)
        {
            if (typeOfParameter == "area")
            {
                // Find the surface area.
                double area = FindTheArea(side);
                return area;
            }
            else if (typeOfParameter == "space")
            {
                // Find the space diagonals.
                double space = FindTheSpace(side);
                return space;
            }
            else if (typeOfParameter == "volume")
            {
                // Find the volume.
                double volume = FindTheVolume(side);
                return volume;
            }
            else if (typeOfParameter == "face")
            {
                // Find face diagonals.
                double face = FindTheFace(side);
                return face;
            }
            return 0;
          
        }

        private static double FindTheFace(double side)
        {
            double face = Math.Sqrt(2 * Math.Pow(side, 2));
            return face;
        }

        private static double FindTheVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        private static double FindTheSpace(double side)
        {
            double space = Math.Sqrt(3* Math.Pow(side, 2));
            return space;
        }

        private static double FindTheArea(double side)
        {
            double area = Math.Pow(side, 2) * 6;

            return area;
        }
    }
}

