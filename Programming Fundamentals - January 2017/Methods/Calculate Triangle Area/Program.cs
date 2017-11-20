
namespace Calculate_Triangle_Area
{
    using System;

    class Methods
    {
        public static void Main()
        {
            var widht = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            double triangelsArea = GetTriangelsArea(widht, height);

            Console.WriteLine(triangelsArea);

        }

        public static double GetTriangelsArea(double widht,double height)
        {
            var trianglesArea = (widht * height) / 2.0;

            return trianglesArea;
        }
    }
}
