using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        // Problem:
        // Write a program that reads two dates in format dd-MM-yyyy and prints the number of working days between these two dates inclusive.Non-working days are:
        // All days that are Saturday or Sunday.
        // All days that are official holidays in Bulgaria:

        // New Year Eve (1 Jan)
        // Liberation Day(3 March)
        // Worker’s day(1 May)
        // Saint George’s Day(6 May)
        // Saints Cyril and Methodius Day(24 May)
        // Unification Day(6 Sept)
        // Independence Day(22 Sept)
        // National Awakening Day(1 Nov)
        // Christmas(24, 25 and 26 Dec)

        //All days not mentioned above are working and should count.

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            input = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !(i.Month == 1 && i.Day == 1) && !(i.Month == 3 && i.Day == 3) && !(i.Month == 5 && i.Day == 1) && !(i.Month == 5 && i.Day == 6) && !(i.Month == 5 && i.Day == 24) && !(i.Month == 9 && i.Day == 6) && !(i.Month == 9 && i.Day == 22) && !(i.Month == 11 && i.Day == 1) && !(i.Month == 12 && i.Day == 24) && !(i.Month == 12 && i.Day == 25) && !(i.Month == 12 && i.Day == 26))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}