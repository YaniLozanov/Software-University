using System;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool ne6to = true;

            if (num <= 1)
            {
                ne6to = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        ne6to = false;
                        break;
                    }
                }
            }
            if (ne6to == false)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
