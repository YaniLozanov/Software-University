using System;

namespace чертаене_на_фигурки
{
    class Program
    {
        static void Main(string[] args)
        {
            string stars = new string('*', 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stars);
            }
        }
    }
}
