using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int secondNum = 1;

            for (int row = 1; row <= num; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    if (secondNum == num + 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"{secondNum++} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
