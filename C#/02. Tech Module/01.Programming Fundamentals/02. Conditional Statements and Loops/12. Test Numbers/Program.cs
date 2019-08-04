using System;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Write a program, which finds all the possible combinations between two numbers – N and M.
            // The first digit decreases from N to 1, and the second digit increases from 1 to M.
            // The two digits form a number. Multiply the two digits, then multiply their product by 3.
            // Add the result to the total sum. 
            // You will also be given a third number, which will be the maximum boundary of the sum.
            // If the sum is equal or greater than this number you should stop the program.
            // See the examples for further information. 


            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int limitNum = int.Parse(Console.ReadLine());

            int result = 0;
            int countOfCombinations = 0;

            for (int firstCrice = firstNum; firstCrice >= 1; firstCrice--)
            {
                for (int secondCrice = 1; secondCrice <= secondNum; secondCrice++)
                {
                    countOfCombinations++;

                    result += (firstCrice * secondCrice) * 3;

                    if (result >= limitNum)
                    {
                        Console.WriteLine($"{countOfCombinations} combinations");
                        Console.WriteLine($"Sum: {result} >= {limitNum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{countOfCombinations} combinations");
            Console.WriteLine($"Sum: {result}");
        }
    }
}
