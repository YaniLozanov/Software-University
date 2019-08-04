using System;

namespace чертаене_на_фигурки
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string stars = new string('*', num);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(stars);
            }
        }
    }
}