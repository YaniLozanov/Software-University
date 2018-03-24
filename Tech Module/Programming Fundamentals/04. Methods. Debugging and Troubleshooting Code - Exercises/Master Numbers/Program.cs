using System;

namespace Master_Numbers
{
    class Program
    {
        // Problem:
        // A master number is an integer that holds the following properties:
        //⦁	Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
        //⦁	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
        //⦁	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
        //Write a program to print all master numbers in the range[1…n].


        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int firstCylce = 1; firstCylce <= inputNum; firstCylce++)
            {
                // Check: Is the inputNum symmetric (palindrome).
                bool isTheNumPalindrome = PalindromeChecker(firstCylce);

                if (isTheNumPalindrome)
                {
                    // Check: Is the sum of digits divisible by 7.
                    bool isTheSumDivisible = DivisibleBySevenChecker(firstCylce);

                    if (isTheSumDivisible)
                    {
                        // Check: Holds at least one even digit.
                        bool oneEvenDigit = EvenNumChecker(firstCylce);

                        if (oneEvenDigit)
                        {
                            Console.WriteLine(firstCylce);
                        }
                    }
                }
            }
        }

        private static bool EvenNumChecker(int firstCycle)
        {
            

            foreach (var symbol in firstCycle.ToString())
            {
                var digits = symbol - '0';

                if (digits % 2 == 0)
                {
                    return true;
                }
              
            }
            return false;
        }

        private static bool DivisibleBySevenChecker(int firstCylce)
        {
            var result = 0;

            foreach (var symbol in firstCylce.ToString())
            {
                var digits = symbol - '0';
                
                    result += digits;               
            }

            if (result % 7 == 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool PalindromeChecker(int firstCylce)
        {
            int left = firstCylce;
            int del = 0;
            int result = 0;

            while (left > 0)
            {
                result = left % 10;
                del = del * 10 + result;
                left = left / 10;

            }

            if (del == firstCylce)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
