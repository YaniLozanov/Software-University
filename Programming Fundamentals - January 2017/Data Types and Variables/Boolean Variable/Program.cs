using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string intputString = Console.ReadLine();

            bool outputInBoolean = Convert.ToBoolean(intputString);

            if (outputInBoolean)
            {
                Console.WriteLine("Yes");
            }
            else if (!outputInBoolean)
            {
                Console.WriteLine("No");
            }
        }
    }
}
