

namespace Draw_a_Filled_Square
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());

            Header(inputNumber);
            Body(inputNumber);
            Footer(inputNumber);

        }

        public static void Header(int inputNumber)
        {
            string firstAndLastRow = string.Format("{0}", new string('-', 2 * inputNumber));
            Console.WriteLine(firstAndLastRow);
        }

        public static void Footer(int inputNumber)
        {
            string firstAndLastRow = string.Format("{0}", new string('-', 2 * inputNumber));
            Console.WriteLine(firstAndLastRow);
        }

        public static void Body(int inputNumber)
        {
            for (int row = 1; row <= inputNumber - 2; row++)
            {
                Console.Write("-");

                for (int cow = 1; cow <= inputNumber - 1 ; cow++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
                
            }
        }
    }
}
