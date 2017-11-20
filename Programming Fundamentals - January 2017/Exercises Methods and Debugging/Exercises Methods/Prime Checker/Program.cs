
namespace Prime_Checker
{
    using System;

    class Program
    {

        public static void Main()
        {
            var inputNum = long.Parse(Console.ReadLine());

            var result = IsPrieme(inputNum);

            Console.WriteLine(result);
        }

        public static bool IsPrieme(long inputNum)
        {

            bool isPrime = true;

            if (inputNum == 0 || inputNum == 1)
            {
                 isPrime = false;

            }
            else
            {
                for (int i = 1; i <= Math.Sqrt(inputNum); i++)
                {

                    if (inputNum % i == 0 &&
                              i != 1 &&
                              i != inputNum)
                    {
                        isPrime = false;
                    }
                }
            }


            return isPrime;
        }
    }
}
