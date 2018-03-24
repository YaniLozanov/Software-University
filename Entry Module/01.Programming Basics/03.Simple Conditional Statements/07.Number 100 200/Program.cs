using System;

namespace using_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100)
            {
                if (number <= 200)
                {
                    Console.WriteLine("Between 100 and 200");
                }
            }
            if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
