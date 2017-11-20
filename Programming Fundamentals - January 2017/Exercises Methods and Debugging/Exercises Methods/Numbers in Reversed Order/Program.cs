
namespace Numbers_in_Reversed_Order
{
    using System;

    class Program
    {
        public static void Main()
        {
            decimal inputNumber = decimal.Parse(Console.ReadLine());

            ReversedTheInputNumber(inputNumber);



        }

        public static void ReversedTheInputNumber(decimal inputnumber)
        {
            inputnumber *= 100;
            decimal firsNum = 0;
            decimal secondNum = 0;
            decimal thirdNum = 0;
            int index = 0;

            foreach (var symbol in inputnumber.ToString())
            {
                var digits = symbol - '0';
                index++;

                if (index == 1)
                {
                    firsNum = digits;
                }
                else if (index == 2)
                {
                    secondNum = digits;
                }
                else if (index == 3)
                {
                    thirdNum = digits;
                }
            }

            if (inputnumber / 100 > 99)
            {
                Console.WriteLine($"{thirdNum}{secondNum}{firsNum}");
            }
            else if (inputnumber > 9)
            {
                Console.WriteLine($"{thirdNum}{secondNum}.{firsNum}");
            }
            else
            {
                Console.WriteLine($"{thirdNum}.{secondNum}{firsNum}");
            }
        }
    }
}
