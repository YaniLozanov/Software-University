using System;

namespace Sun_Glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double num2 = num;
            string star = new string('*', num * 2);
            string line = new string('/', num * 2 - 2);
            string lineStrigt = new string('|', num);
            string space = new string(' ', num);
            double number = Math.Ceiling(num2 / 2);

            Console.WriteLine("{0}{1}{0}", star, space);

            for (int y = 0; y < num - 2; y++)
            {
                Console.Write("*{0}*", line);

                if (y == number - 2)
                {
                    Console.Write(lineStrigt);
                }
                else
                {
                    Console.Write("{0}", space);
                }

                Console.WriteLine("*{0}*", line);
            }
            Console.WriteLine("{0}{1}{0}", star, space);
        }
    }
}
