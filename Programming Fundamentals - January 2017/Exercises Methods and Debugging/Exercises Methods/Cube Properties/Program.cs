using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine().ToLower();

            if (parameter == "face")
            {
                GetFace(side);
            }
            else if (parameter == "space")
            {
                GetSpace(side);
            }
            else if (parameter == "volume")
            {
                GetVolume(side);
            }
            else if (parameter == "area")
            {
                GetArea(side);
            }

        }

        public static void GetFace(double side)
        {
            var faceDiagonal = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2));

            Console.WriteLine($"{faceDiagonal:f2}");
        }

        public static void GetSpace(double side)
        {
            var spaceDiagonals = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2) + Math.Pow(side, 2));

            Console.WriteLine($"{spaceDiagonals:f2}");
        }

        public static void GetVolume(double side)
        {
            var volume = Math.Pow(side, 3);

            Console.WriteLine($"{volume:f2}");
        }

        public static void GetArea(double side)
        {
            var area = 6 * Math.Pow(side, 2);

            Console.WriteLine($"{area:f2}");
        }
    }
}
