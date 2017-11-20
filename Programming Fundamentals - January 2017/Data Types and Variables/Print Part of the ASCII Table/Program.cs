using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var stopIndex = int.Parse(Console.ReadLine());

            for (int symbol = startIndex; symbol <= stopIndex; symbol++)
            {
                Console.Write($" {(char)symbol}");
            }
            Console.WriteLine();
        }
    }
}
