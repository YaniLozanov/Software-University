using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)

        {
            int num = int.Parse(Console.ReadLine());

            string plus = "+ ";
            string line = "| ";
            string spaces = " ";
            string minus = "-";
            string minuses = string.Empty;

            for (int y = 0; y < 1; y++)
            {
                for (int minusesNum = 0; minusesNum < num - 2; minusesNum++)
                {
                    minuses += minus + spaces;
                }
                Console.WriteLine("{0}{1}{0}", plus, minuses);
                for (int x = 0; x < num - 2; x++)
                {
                    Console.WriteLine("{0}{1}{0}", line, minuses);
                }
                Console.WriteLine("{0}{1}{0}", plus, minuses);
            }
        }
    }
}

