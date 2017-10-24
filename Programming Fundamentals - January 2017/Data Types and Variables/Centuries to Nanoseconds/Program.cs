using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCenturies = int.Parse(Console.ReadLine());

            int turnTheCenturiesInToYears = inputCenturies * 100;
            double turnTheYearsInToDays = Math.Floor(turnTheCenturiesInToYears * 365.2422);
            double turnTheDaysInToHours = turnTheYearsInToDays * 24;
            long turnTheHoursInToMinutes = (long)turnTheDaysInToHours * 60;
            long turnTheMinutesInToSeconds = turnTheHoursInToMinutes * 60;
            long turnTheSecondsInToMiliseconds = turnTheMinutesInToSeconds * 1000;
            long turnTheMilisecondsInToMicroseconds = turnTheSecondsInToMiliseconds * 1000;
            ulong turnTheMicrosecondsInToNanoseconds = (ulong)(turnTheMilisecondsInToMicroseconds * 1000);



            Console.WriteLine($"{inputCenturies} centuries = " +
                              $"{turnTheCenturiesInToYears} years = " +
                              $"{turnTheYearsInToDays} days = " +
                              $"{turnTheDaysInToHours} hours = " +
                              $"{turnTheHoursInToMinutes} minutes = " +
                              $"{turnTheMinutesInToSeconds} seconds = " +
                              $"{turnTheSecondsInToMiliseconds} milliseconds = " +
                              $"{turnTheMilisecondsInToMicroseconds} microseconds = " +
                              $"{turnTheMicrosecondsInToNanoseconds} nanoseconds");

        }
    }
}
