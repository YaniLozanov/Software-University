using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = new int[firstLine.Length];


            for (int i = 0; i < firstLine.Length; i++)
            {
                sum[firstLine.Length - i - 1] = firstLine[i];
            }

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
