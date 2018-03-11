using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Main()
        {

            


            for (int i = 97; i <= 122; i++)
            {
                var lettersLenght = new int[123 - 97];

                lettersLenght[i - 97] = i;

                

                Console.WriteLine((char)lettersLenght[i - 97]);
            }
        }
    }
}
