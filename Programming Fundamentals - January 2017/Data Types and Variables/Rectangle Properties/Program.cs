using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Perimeter

            var perimeter = (width * 2) + (height * 2);
            Console.WriteLine(perimeter);

            //Area

            var area = width * height;
            Console.WriteLine(area);

            //diagonal 

            var diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine(diagonal);
        
        }
    }
}
