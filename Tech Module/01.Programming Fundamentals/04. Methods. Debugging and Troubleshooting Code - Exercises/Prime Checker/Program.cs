using System;

namespace Prime_Checker
{
    class Program
    {
        // Problem:
        //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.Examples:

        static void Main(string[] args)

        {
            long inputNum = long.Parse(Console.ReadLine());


            // Check: is the number prime:
            bool isTheNumPrime = isPrime(inputNum);

            Console.WriteLine(isTheNumPrime);
        }

        private static bool isPrime(long inputNum)
        {
            bool isTheNumPrime = true;


            if (inputNum == 0 || inputNum == 1)
            {
                isTheNumPrime = false;
            }

            for (int firstCycle = 1; firstCycle <= Math.Sqrt(inputNum); firstCycle++)
            {
                if (inputNum % firstCycle == 0 && firstCycle !=1 )
                {
                    isTheNumPrime = false;
                    return isTheNumPrime;
                }
                
            }

            return isTheNumPrime;
        }
    }
}
