
namespace Prime_Checker
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {

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
