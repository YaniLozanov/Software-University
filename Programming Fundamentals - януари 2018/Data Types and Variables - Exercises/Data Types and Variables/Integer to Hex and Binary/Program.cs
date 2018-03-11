using System;


namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // Convert in hexadecimal:
            string hexadecimal = Convert.ToString(number, 16);
            Console.WriteLine(hexadecimal.ToUpper());

            // Convert in Binary:
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary.ToUpper());

        }
    }
}
