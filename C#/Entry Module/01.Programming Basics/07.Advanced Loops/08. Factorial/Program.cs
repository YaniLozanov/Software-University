using System;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 1;

            while (num > 0)
            {
                sum = num * sum;
                num--;
            }
            Console.WriteLine(sum);
        }
    }
}
