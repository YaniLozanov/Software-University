using System;


namespace Of_Leva_in_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());

            double leva = Math.Round(dollars * 1.79549, 2);

            Console.WriteLine($"{leva} BGN ");
        }
    }
}
