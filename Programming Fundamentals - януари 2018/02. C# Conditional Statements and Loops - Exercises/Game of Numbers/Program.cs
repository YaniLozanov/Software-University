using System;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;

            for (int fistCycle = startNum; fistCycle <= stopNum; fistCycle++)
            {
                for (int secondCycle = startNum; secondCycle <= stopNum; secondCycle++)
                {
                    countOfCombinations++;

                    if (fistCycle + secondCycle == magicNum)
                    {
                        Console.WriteLine($"Number found! {secondCycle} + {fistCycle} = {magicNum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{countOfCombinations} combinations - neither equals {magicNum}");    
            
        }
    }
}
