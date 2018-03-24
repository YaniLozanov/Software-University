using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourPassword = Console.ReadLine();

            if (yourPassword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
