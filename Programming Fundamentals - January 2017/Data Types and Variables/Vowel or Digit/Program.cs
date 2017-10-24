using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            bool vowel = symbol == 'a' ||
                         symbol == 'e' ||
                         symbol == 'i' ||
                         symbol == 'o' ||
                         symbol == 'u';

            bool digit = (int)symbol >= 48 && (int)symbol <= 57;

            if (vowel)
            {
                Console.WriteLine("vowel");
            }
            else if (digit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }

    }
}
