using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int num2 = 1;

            while (num2 <= num)
            {
                Console.WriteLine(num2);
                num2 = num2 * 2 + 1;
            }
        }
    }
}
