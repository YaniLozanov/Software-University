using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearTipe = Console.ReadLine();
            var holyDaysInYear = int.Parse(Console.ReadLine());
            var weekendsInYear = int.Parse(Console.ReadLine());

            var normalYear = yearTipe == "normal";
            var leapYear = yearTipe == "leap";
            var sofiaPlayDays = (48.0 - weekendsInYear) * 3 / 4 + (2 / 3.0 * holyDaysInYear);

            var bonusDays = 0.0;
            var playingDays = 0.0;

            if (normalYear)
            {
                bonusDays = 0;
                playingDays = sofiaPlayDays + weekendsInYear;
            }
            else if (leapYear)
            {
                playingDays = sofiaPlayDays + weekendsInYear;
                bonusDays = playingDays / 100.0 * 15;

            }

            Console.WriteLine(Math.Floor(playingDays + bonusDays));
        }
    }
}
