using System;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Create a method that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1.
            // charAt (0) with str2.charAt (0) and add to the total sum).
            // Then continue with the next two characters.
            // If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.


            string[] input = Console.ReadLine().Split(' ').ToArray();

            string firstString = input[0];
            string secondString = input[1];
            
            int result = GiveTheSumOfCharactres(firstString, secondString);

            Console.WriteLine(result);

        }

        private static int GiveTheSumOfCharactres(string firstString, string secondString)
        {
            int theShorteString = Math.Min(firstString.Length, secondString.Length);
            int theLongerString = Math.Max(firstString.Length, secondString.Length);
            int sum = 0;


            for (int i = 0; i < theLongerString; i++)
            {
                if (i < theShorteString)
                {
                    sum += (int)(firstString[i]) * (int)(secondString[i]);
                }
                else if (firstString.Length > secondString.Length)
                {
                    sum += (int)(firstString[i]);
                }
                else
                {
                    sum += (int)(secondString[i]);
                }
            }


            return sum;

        }
    }
}
