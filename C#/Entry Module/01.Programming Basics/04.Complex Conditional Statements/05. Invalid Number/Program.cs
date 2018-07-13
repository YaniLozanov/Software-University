using System;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var valid = (number >= 100 && number <= 200) || number == 0;

            if (!valid)
            {
                Console.WriteLine("invalid");
            }          
        }
    }
}
