using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
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
