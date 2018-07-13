using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program, which can receive any type of input, but upon receiving anything other than an integer – stops the execution of the program and prints how many numbers were read.


            int index = 0;

            while (true)
            {
                try
                {
                    int data = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {

                    Console.WriteLine(index);
                    return;
                }
                index++;

            }


        }
    }
}
