using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            // On first line, you receive – distance in meters
            // On second – hours
            // On third – minutes
            // On fourth – seconds

            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            //Speed: meter per seconds (m/s)

            float hoursInSeconds = hours * 60 * 60;
            float minutesInSeconds = minutes * 60;
            float totalTimeInSeconds = hoursInSeconds + minutesInSeconds + seconds;
            float meterPerSecond = distanceInMeters / totalTimeInSeconds;

            Console.WriteLine($"{meterPerSecond:f7}");

            //Speed: kilometers per hour (km/h)

            float secondsInHours = ((seconds / 60) / 60);
            float minutesInHours = minutes / 60;
            float totalTimeInHours = hours + minutesInHours + secondsInHours;
            float distanceInKilometers = distanceInMeters / 1000;
            float kilometersPerHours = distanceInKilometers / totalTimeInHours;

            Console.WriteLine($"{kilometersPerHours:f7}");

            //Speed: milies per hours (mi/h)

            float metersInMilies = distanceInMeters / 1609;
            float miliesPerHour = metersInMilies / totalTimeInHours;

            Console.WriteLine($"{miliesPerHour:f7}");
        }
    }
}
