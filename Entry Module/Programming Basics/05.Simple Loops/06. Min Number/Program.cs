using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int num = int.MaxValue;

            for (int i = 1; i <= cycles; i++)
            {
                int max = int.Parse(Console.ReadLine());

                if (max < num)
                {
                    num = max;
                }
            }
            Console.WriteLine(num);
        }
    }
}
