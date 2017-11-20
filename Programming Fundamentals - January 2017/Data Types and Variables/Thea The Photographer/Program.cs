using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int takenedPictures = int.Parse(Console.ReadLine());
            int timeForFilterPerPicture = int.Parse(Console.ReadLine());
            int procentOfUsefulPictures = int.Parse(Console.ReadLine());
            int timeForEveryPictureToBeUploaded = int.Parse(Console.ReadLine());

            long totalTimeForFilter = (long)takenedPictures * (long)timeForFilterPerPicture;
            double usefulPicutres = Math.Ceiling((takenedPictures * procentOfUsefulPictures) / 100.0);

            long totalTimeInSeconds = (long)((usefulPicutres * timeForEveryPictureToBeUploaded) + totalTimeForFilter);


            TimeSpan t = TimeSpan.FromSeconds(totalTimeInSeconds);

            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds);

            Console.WriteLine(answer);






        }
    }
}
