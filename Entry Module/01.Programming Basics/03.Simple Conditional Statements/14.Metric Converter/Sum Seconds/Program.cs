using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTime = double.Parse(Console.ReadLine());
            var secondTime = double.Parse(Console.ReadLine());
            var thirdTime = double.Parse(Console.ReadLine());

            double sumTime = firstTime + secondTime + thirdTime;

            double minutes = Math.Floor(sumTime / 60);
            double seconds = sumTime % 60;

            if (sumTime < 10)
            {
                Console.WriteLine($"0:0{seconds}");
            }
            else
            {
                if (seconds < 10)
                {
                    Console.WriteLine($"{minutes}:0{seconds}");
                }
                else
                {
                    Console.WriteLine($"{minutes}:{seconds}");
                }
            }
        }
    }
}
