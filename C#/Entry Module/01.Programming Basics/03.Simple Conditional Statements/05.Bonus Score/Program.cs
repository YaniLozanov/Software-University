using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5;
            }
            if (points > 100)
            {
                if (points <= 1000)
                {
                    bonusPoints = points * 0.20;
                }
            }
            if (points > 1000)
            {
                bonusPoints = points * 0.10;
            }

            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            if (points % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
