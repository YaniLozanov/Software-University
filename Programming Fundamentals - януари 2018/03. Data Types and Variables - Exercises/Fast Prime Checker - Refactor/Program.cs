using System;

namespace Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstCycle = 2; firstCycle <= number; firstCycle++)
            {
                bool prime = true;

                for (int secondCylce = 2; secondCylce <= Math.Sqrt(firstCycle); secondCylce++)
                {
                    if (firstCycle % secondCylce == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstCycle} -> {prime}");
            }

        }
    }
}
