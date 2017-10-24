using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());            

            Console.WriteLine("{1}",number, Convert.ToString(number, 16).ToUpper());
            Console.WriteLine("{1}", number, Convert.ToString(number, 2).ToUpper());

        }
    }
}
