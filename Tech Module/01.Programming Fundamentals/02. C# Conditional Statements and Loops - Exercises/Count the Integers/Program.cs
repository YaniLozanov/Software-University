using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
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
