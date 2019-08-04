using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program that takes a base-N number and converts it to a base-10 number (0 to 1050), where 2 <= N <= 10.
            // The input consists of 1 line containing two numbers separated by a single space.
            // The first number is the base N to which you have to convert.
            // The second one is the base N number to be converted.Do not use any built in converting functionality, try to write your own algorithm.
         

            string[] input = Console.ReadLine().Trim().Split();
            int baseNNum = int.Parse(input[0]);
            char[] baseTenNum = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = 0; i < baseTenNum.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(baseTenNum[i]);
                result += currentNum * BigInteger.Pow(baseNNum, baseTenNum.Length - i - 1);
            }

            Console.WriteLine(result);
        }
    }
}