
namespace English_Name_оf_The_Last_Digit
{
    using System;

    class Program
    {
        public static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());

            string digitsName = GetTheEnglishNameOfLastDigit(inputNumber);

            Console.WriteLine(digitsName);
        }

        public static string GetTheEnglishNameOfLastDigit(long inputNumber)
        {
            long result = 0;

            foreach (var symbol in inputNumber.ToString())
            {
                var digits = symbol - '0';

                result = digits;
            }

            string name = GetName(result);

            return name;
        }

        public static string GetName(long result)
        {
            string name = string.Empty;
            if (result == 0)
            {
                name = "zero";
            }
           else if (result == 1)
            {
                name = "one";
            }
            else if (result == 2)
            {
                name = "two";
            }
            else if (result == 3)
            {
                name = "three";
            }
            else if (result == 4)
            {
                name = "four";
            }
            else if (result == 5)
            {
                name = "five";
            }
            else if (result == 6)
            {
                name = "six";
            }
            else if (result == 7)
            {
                name = "seven";
            }
            else if (result == 8)
            {
                name = "eight";
            }
            else if (result == 9)
            {
                name = "nine";
            }

            return name;
        }
    }
}
