using System;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
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
