using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string star = "*" + " ";
            string space = " ";
            string stars = string.Empty;
            string spaces = string.Empty;

            for (int i = 0; i < num; i++)
            {
                spaces = string.Empty;

                for (int cyclesSpaces = num - i; cyclesSpaces > 1; cyclesSpaces--)
                {
                    spaces += space;
                }
                for (int cycleStars = 0; cycleStars < 1; cycleStars++)
                {
                    stars += star;
                }
                Console.WriteLine("{0}{1}", spaces, stars);
            }
            for (int i = 0; i < num - 1; i++)
            {
                stars = string.Empty;

                for (int cyclesSpaces = num - i; cyclesSpaces > 1; cyclesSpaces--)
                {
                    stars += star;
                }
                for (int cycleStars = 0; cycleStars < 1; cycleStars++)
                {
                    spaces += space;
                }
                Console.WriteLine("{0}{1}", spaces, stars);
            }
        }
    }
}
