using System;
using System.Linq;

namespace Arrays___Exercises
{
    class Program
    {



        // Problem:
        // Read two arrays of words and find the length of the largest common end(left or right).

        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

            string[] secondArr = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

            // Find the front common.
            int fronCount = ScanTheArrFromLeft(firstArr, secondArr);    
            
            // Count the largest common of equal words in sequence.
            int secondCount = - 1;

            // secondCycle`s started point.
            int index = 0;

            for (int firstCylcle = 0; firstCylcle < firstArr.Length; firstCylcle++)
            {
                for (int secondCycle = index; secondCycle < secondArr.Length; secondCycle++)
                {
                    if (firstArr[firstCylcle] == secondArr[secondCycle])
                    {
                        secondCount++;
                        index = secondCycle + 1;
                        break;
                    }
                }            
            }

            int longestCommon = Math.Max(fronCount, secondCount);


            Console.WriteLine(longestCommon);
        }
        private static int ScanTheArrFromLeft(string[] firstArr, string[] secondArr)
        {
            int count = 0;
            int theShorter = Math.Min(firstArr.Length, secondArr.Length);

            for (int firstCycle = 0; firstCycle < theShorter; firstCycle++)
            {
                if (firstArr[firstCycle] == secondArr[firstCycle])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
