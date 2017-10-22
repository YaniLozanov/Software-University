using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInHexadecimal = Console.ReadLine();

            int numberInDecimal = Convert.ToInt32(numberInHexadecimal,16);

            Console.WriteLine(numberInDecimal);


        }
    }
}
