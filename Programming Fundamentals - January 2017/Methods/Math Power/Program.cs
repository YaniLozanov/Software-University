

namespace Math_Power
{
    using System;

    class Methods
    {
        public static void Main()
        {
            double inputNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseTheNumber(inputNumber, power);

            Console.WriteLine(result);

        }

        public static double RaiseTheNumber(double inputNumber, double power)
        {
            double raisedNum = 1;

            for (int i = 1; i <= power; i++)
            {
                raisedNum *= inputNumber;
            }

            return raisedNum;
        }
    }
}
