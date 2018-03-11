using System;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            int index = (char)(Math.Max(firstLetter, secondLetter));
            
            for (char firstCycle = firstLetter; firstCycle <= index; firstCycle++)
            {
                for (char secondCycle = firstLetter; secondCycle <= index; secondCycle++)
                {
                    for (char thirdCycle = firstLetter; thirdCycle <=index; thirdCycle++)
                    {
                        if (firstCycle != thirdLetter && secondCycle != thirdLetter && thirdCycle != thirdLetter)
                        {
                            Console.Write($"{firstCycle}{secondCycle}{thirdCycle} ");
                        }
                       
                    }
                }
            }

        }
    }
}
