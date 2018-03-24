using System;
using System.Numerics;

namespace Thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thea is a photographer. She takes pictures of people on special events.
            //She is a good friend and you want to help her.
            //She wants to inform her clients when their pictures will be ready. Since the number of pictures
            //is big and it requires time for editing(#nofilter, #allnatural) every single picture 
            //you decide to write a program in order to help her.
            //Thea follows this pattern: first she takes all pictures.Then she goes through every single picture
            //to filter these pictures that are considered "good".Then she needs to upload every single filtered picture to her cloud.
            //She is considered ready when all filtered pictures are uploaded in her picture storage.
            //You will receive the number of pictures she had taken.Then the approximate time in seconds for every picture
            //to be filtered.Then a filter factor – a percentage(integer number) of the total photos(rounded to the nearest bigger integer value e.g. 5.01-> 6)
            //that are good enough to be given to her clients(Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded
            //will be given again in seconds.Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.

            long numOfPictures = long.Parse(Console.ReadLine());
            long filterTimeInSecondsPerPicures = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long timeForUploadedPerPictures = long.Parse(Console.ReadLine());


            // filter time:
            long filterTime = numOfPictures * filterTimeInSecondsPerPicures;

            // good pictures:
            double goodPictures = (filterFactor / 100.0) * numOfPictures;
            goodPictures = Math.Ceiling(goodPictures);

            // upload time:
            long uploadTime = (long)goodPictures * timeForUploadedPerPictures;

            // total time in seconds:
            long totalTimeInSeconds = (long)(filterTime + uploadTime);

            // time in format : 0:00:00:00 / days:hours:minutes:seconds:
            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);
            string timeInFormat = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            time.Days,
                            time.Hours,
                            time.Minutes,
                            time.Seconds);                           

            Console.WriteLine(timeInFormat);
        }
    }
}
