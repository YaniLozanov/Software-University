using System;

namespace Hause
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int y = 1; y <= num; y++)
            {
                if (num % 2 == 0 && y % 2 == 0)
                {
                    string minuses = new string('-', (num - y) / 2);
                    string starsEven = new string('*', y);
                    Console.WriteLine("{0}{1}{0}", minuses, starsEven);
                }
                else if (num % 2 != 0 && y % 2 != 0)
                {
                    string minuses = new string('-', (num - y) / 2);
                    string starsOdd = new string('*', y);
                    Console.WriteLine("{0}{1}{0}", minuses, starsOdd);
                }

            }
            if (num % 2 == 0)
            {
                for (int y = 0; y < num / 2; y++)
                {
                    string stars = new string('*', num - 2);

                    Console.WriteLine("|{0}|", stars);
                }
            }
            else
            {
                for (int y = 0; y < num / 2; y++)
                {
                    string stars = new string('*', num - 2);
                    Console.WriteLine("|{0}|", stars);
                }
            }
        }
    }
}
