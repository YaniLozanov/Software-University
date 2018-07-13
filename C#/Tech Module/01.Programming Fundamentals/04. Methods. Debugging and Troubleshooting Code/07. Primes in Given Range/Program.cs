namespace Prime_Checker
{
    using System;
    using System.Collections.Generic;

    class Program
    {

        // Problem:
        // Write a method that calculates all prime numbers in given range and returns them as list of integers:
        // Write a method to print a list of integers.
        // Write a program that enters two integer numbers(each at a separate line) and prints all primes in their range, separated by a comma.


        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", PrintAllPrimeDigitsInTheRange(startNum, stopNum).ToArray());
            Console.WriteLine(numbers);

        }

        static List<int> PrintAllPrimeDigitsInTheRange(int startNum,
                                                        int stopNum)
        {
            var result = new List<int>();

            for (int firstIndex = startNum; firstIndex <= stopNum; firstIndex++)
            {
                bool isPride = true;

                for (int secondIndex = 2; secondIndex <= Math.Sqrt(firstIndex); secondIndex++)
                {
                    if (firstIndex % secondIndex == 0)
                    {
                        isPride = false;
                        break;
                    }

                }

                if (isPride &&
                    firstIndex != 0 &&
                    firstIndex != 1)
                {
                    result.Add(firstIndex);
                }

            }
            return result;

        }
    }
}
