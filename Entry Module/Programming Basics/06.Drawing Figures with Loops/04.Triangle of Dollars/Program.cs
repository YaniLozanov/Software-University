using System;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            char dollar = '$';
            char spaces = ' ';

            for (int y = 1; y <= num; y++)
            {
                for (int i = 1; i <= y; i++)
                {
                    Console.Write("{0}{1}", dollar, spaces);
                }
                Console.WriteLine();
            }
        }
    }
}