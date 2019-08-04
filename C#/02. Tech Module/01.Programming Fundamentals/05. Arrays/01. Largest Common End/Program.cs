using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Largest_Common_End___Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Read two arrays of words and find the length of the largest common end (left or right).


            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();


            int firstCounter = 0;
            int secondCounter = 0;

            firstCounter = SearchTheLeftSide(firstArr, secondArr);

            secondCounter = SearchTheRightSide(firstArr, secondArr);

            if (firstCounter > secondCounter)
            {
                Console.WriteLine(firstCounter);
            }
            else
            {
                Console.WriteLine(secondCounter);
            }
        }

        private static int SearchTheRightSide(string[] firstArr, string[] secondArr)
        {
            int theShorterArr = Math.Min(firstArr.Length, secondArr.Length);
            int secondCounter = 0;

            for (int i = 0; i < theShorterArr; i++)
            {
                if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    secondCounter++;
                }
                else
                {
                    break;
                }
            }

            return secondCounter;
        }

        private static int SearchTheLeftSide(string[] firstArr, string[] secondArr)
        {
            int theShorterArr = Math.Min(firstArr.Length, secondArr.Length);
            int counter = 0;

            for (int firstCylce = 0; firstCylce < theShorterArr; firstCylce++)
            {
                if (firstArr[firstCylce] == secondArr[firstCylce])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
