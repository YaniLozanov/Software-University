using System;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 0; i <= num / 2; i++)
            {
                Console.WriteLine(sum);
                sum *= 4;
            }
        }
    }
}
