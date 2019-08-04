using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100Ml = int.Parse(Console.ReadLine());
            int sugarContentPer100Ml = int.Parse(Console.ReadLine());

            double energyForTheGivenVolume = (volume / 100.0) * energyContentPer100Ml;
            double sugarForTheGivenVolume = (volume / 100.0) * sugarContentPer100Ml;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyForTheGivenVolume}kcal, {sugarForTheGivenVolume}g sugars");



        }
    }
}
