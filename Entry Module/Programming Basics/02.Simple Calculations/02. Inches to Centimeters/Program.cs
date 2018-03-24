using System;


namespace inches_to_centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());

            double centimeter = inches * 2.54;

            Console.Write("Centimeters = ");
            Console.WriteLine(centimeter);
        }
    }
}
