using System;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                    num = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine(num);
        }
    }
}
