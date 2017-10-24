using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());

            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            // Speed in meters per second 

            float hoursToMinutes = hours * 60.0f;
            float totalMinutes = hoursToMinutes + minutes;
            float minutesToSeconds = totalMinutes * 60.0f;
            float totalSeconds = minutesToSeconds + seconds;

            float speedInMetersPerSecond =(distanceInMeters / totalSeconds);
            Console.WriteLine(speedInMetersPerSecond);

            //Speed in kilometers per hour

            float metersToKilometers = distanceInMeters / 1000.0f;

            float secondsToMinutes = seconds / 60.0f;
            float totalMinutesToHours = (secondsToMinutes + minutes) / 60.0f;
            float totalHours = totalMinutesToHours + hours;
            

            float speedInKilometersPerHour =( metersToKilometers / totalHours);
            Console.WriteLine(speedInKilometersPerHour);

            //Speed in miles per hour

            float distanceInMiles = distanceInMeters / 1609.0f;

            float speedInMiliesPerHour = distanceInMiles / totalHours;
            Console.WriteLine(speedInMiliesPerHour);

        }
    }
}
