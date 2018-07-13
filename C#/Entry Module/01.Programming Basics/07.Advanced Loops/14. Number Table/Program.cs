using System;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstIndex = 1;
            int secondIndex = num - 1;
            int thirtIndex = num - 2;
            int fourthIndex = num;

            for (int row = 2; row <= num + 1; row++)
            {
                for (int cow = firstIndex; cow <= num; cow++)
                {
                    Console.Write($"{cow} ");

                }

                firstIndex = row;

                if (row > 2)
                {
                    for (int cowSecondPart = num - 1; cowSecondPart >= num - firstIndex + 2; cowSecondPart--)
                    {
                        Console.Write($"{cowSecondPart} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
