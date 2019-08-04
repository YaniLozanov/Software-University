using System;

namespace English_Name_оf_the_Last_Digit
{
    class Program
    {
        // Problem:
        // Write a method that returns the English name of the last digit of a given number.
        // Write a program that reads an integer and prints the returned value from this method.

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            string lastDigitsName = GetLastDigitsName(number);

            Console.WriteLine(lastDigitsName);
        }

        static string GetLastDigitsName(long number)
        {

            // Get the last digit.
            long lastDigit = GetLastDigit(number);

            // Get the digits name.
            if (lastDigit == 1)
            {
                return "one";
            }
            else if (lastDigit == 2)
            {
                return "two";
            }
            else if (lastDigit == 3)
            {
                return "three";
            }
            else if (lastDigit == 4)
            {
                return "four";
            }
            else if (lastDigit == 5)
            {
                return "five";
            }
            else if (lastDigit == 6)
            {
                return "six";
            }
            else if (lastDigit == 7)
            {
                return "seven";
            }
            else if (lastDigit == 8)
            {
                return "eight";
            }
            else if (lastDigit == 9)
            {
                return "nine";
            }
            else
            {
                return "zero";
            }
        }

        static long GetLastDigit(long number)
        {
            var result = 0;

            foreach (var symbol in number.ToString())
            {
                var digits = symbol - '0';


                result = digits;


            }
            return result;

        }
    }
}
