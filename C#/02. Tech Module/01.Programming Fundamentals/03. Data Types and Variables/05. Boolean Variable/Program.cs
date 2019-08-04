using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that reads a string, converts it to Boolean variable and prints “Yes” if the variable is true and “No” if the variable is false.


            string word = Console.ReadLine();

            bool wordBool = Convert.ToBoolean(word);

            if (wordBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}

