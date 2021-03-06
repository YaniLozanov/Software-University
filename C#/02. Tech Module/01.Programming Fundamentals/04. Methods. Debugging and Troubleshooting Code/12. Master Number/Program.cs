﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        // Problem:
        // A master number is an integer that holds the following properties:
        // Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
        // Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
        // Holds at least one even digit, e.g. 232, 707, 6886, 87578.
        // Write a program to print all master numbers in the range[1…n].


        public static void Main()
        {
            var stopNum = int.Parse(Console.ReadLine());

            GetMasterNumbers(stopNum);


        }

        public static void GetMasterNumbers(int stopNum)
        {

            GetPolindrome(stopNum);


        }

        private static void GetPolindrome(int stopNum)
        {

            for (int i = 1; i <= stopNum; i++)
            {
                int inverseNum = 0;
                int helpNum = 1;
                int numOfDigits = 0;

                int forwardNum = 0;
                int secondHelpNum = i;
                int numOfEqualDigits = 0;

                while (inverseNum < i)
                {
                    inverseNum = i % (10 * helpNum);
                    helpNum *= 10;

                    numOfDigits++;

                }

                for (int secondI = 1; secondI <= numOfDigits; secondI++)
                {

                    inverseNum = secondHelpNum % 10;
                    helpNum = secondHelpNum / 10;
                    secondHelpNum = helpNum;

                    forwardNum = ((int)(i / Math.Pow(10, numOfDigits - secondI)) % 10);

                    if (inverseNum == forwardNum)
                    {
                        numOfEqualDigits++;
                    }

                }
                if (numOfEqualDigits == numOfDigits)
                {
                    GetSumOfDigits(i, numOfDigits);
                }


            }

        }

        public static void GetSumOfDigits(int i, int numOfDigits)
        {
            int forwardNum = 0;

            for (int secondI = 1; secondI <= numOfDigits; secondI++)
            {
                forwardNum += ((int)(i / Math.Pow(10, numOfDigits - secondI)) % 10);
            }
            if (forwardNum % 7 == 0)
            {
                ContainsEvenDigit(i);
            }
        }

        public static void ContainsEvenDigit(int i)
        {

            var result = 0;

            foreach (var symbol in i.ToString())
            {
                var digits = symbol - '0';

                if (digits % 2 == 0)
                {
                    result++;
                }
            }
            if (result > 0)
            {
                Console.WriteLine(i);
            }

        }

    }
}

