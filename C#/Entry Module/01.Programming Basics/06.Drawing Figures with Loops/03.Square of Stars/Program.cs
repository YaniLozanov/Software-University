using System;

namespace чертаене_на_фигурки
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            char stars = '*';
            char spaces = ' ';

            for (int i = 0; i < num; i++)
            {
                for (int s = 0; s < num; s++)
                {
                    Console.Write("{0}{1}", stars, spaces);
                }
                Console.WriteLine();
            }
        }
    }
}