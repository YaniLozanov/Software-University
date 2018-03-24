using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int num = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char bukwa = text[i];

                switch (bukwa)
                {
                    case 'a':
                        num += 1;
                        break;
                    case 'e':
                        num += 2;
                        break;
                    case 'i':
                        num += 3;
                        break;
                    case 'o':
                        num += 4;
                        break;
                    case 'u':
                        num += 5;
                        break;
                }
            }
            Console.WriteLine(num);
        }
    }
}
