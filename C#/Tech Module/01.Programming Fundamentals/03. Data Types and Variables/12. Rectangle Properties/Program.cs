using System;

namespace Rectangle_Properties_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Create a program to calculate rectangle’s perimeter, area and diagonal by given its width and height.

            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Rectangeles Perimeter:
            double perimeter = widht * 2 + height * 2;
            Console.WriteLine(perimeter);

            //Rectangles Area:
            double area = widht * height;
            Console.WriteLine(area);

            //Rectangles Diagona:
            double diagonal = Math.Sqrt((widht * widht) + (height * height));
            Console.WriteLine(diagonal);

        }
    }
}
