using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            string line = " | ";
            string spaces = new string(' ', num);

            Console.WriteLine("{0}{1}", spaces, line);

            for (int row = 0; row < num; row++)
            {
                for (int cow = 0; cow < num - row - 1; cow++)
                {
                    Console.Write(" ");
                }
                for (int cow = 0; cow <= row; cow++)
                {
                    Console.Write("*");
                }
                for (int cow = 0; cow < 1; cow++)
                {
                    Console.Write(line);
                }
                for (int cow = 0; cow <= row; cow++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
