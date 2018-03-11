using System;

namespace Тест
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12345;
            int left = n;
            int rev = 0;
            int r = 0;
            while (left > 0)
            {
                r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

            Console.WriteLine(rev);
        }
    }
}
