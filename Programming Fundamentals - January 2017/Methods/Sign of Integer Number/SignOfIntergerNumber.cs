using System;

namespace Sign_of_Integer_Number
{
    using System;

    public class SignOfIntergerNumber
    {
       public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            PositiveNumber(num);

        }

        public static void PositiveNumber(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}

