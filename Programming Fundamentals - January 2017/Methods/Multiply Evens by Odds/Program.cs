
namespace Multiply_Evens_by_Odds
{
    using System;

    class Methods
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

           MultipliesTheSumOfEvenAndSumOfOddDigits(number);
        
        }

        public static void MultipliesTheSumOfEvenAndSumOfOddDigits(int  number)
        {
            var result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            Console.WriteLine(result);
        }

        public static int GetSumOfEvenDigits(int number)
        {
            var result = 0;

            foreach (var symbol in number.ToString())
            {
                var digits = symbol - '0';

                if (digits % 2 == 0)
                {
                    result += digits;
                }
            }

            return result;
        }

        public static int GetSumOfOddDigits(int number)
        {
            var result = 0;

            foreach (var symbol in number.ToString())
            {
                var digits = symbol - '0';


                if (digits % 2 != 0)
                {
                    result += digits;
                }
            }

            return result;
        }

    }
}
