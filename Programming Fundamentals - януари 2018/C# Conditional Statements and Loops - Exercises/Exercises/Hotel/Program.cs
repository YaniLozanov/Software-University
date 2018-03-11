using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
 
            
            string may = "May";
            string october = "October";          
            string june = "June";
            string september = "September";
            string july = "July";
            string august = "August";
            string december = "December";

            double priceForStudioPerNight = 0.0;
            double priceForDoublePerNight = 0.0;
            double priceForSuitePerNight = 0.0;

            double discountForStudio = 0.0;
            double discountForDouble = 0.0;
            double discountForSuite = 0.0;

            double totalPriceForStudio = 0.0;
            double totalPriceForDouble = 0.0;
            double totalPriceForSuite = 0.0;

            if (month == may || month == october)
            {
                priceForStudioPerNight = 50;
                priceForDoublePerNight = 65;
                priceForSuitePerNight = 75;
            }
            else if (month == june || month == september)
            {
                priceForStudioPerNight = 60;
                priceForDoublePerNight = 72;
                priceForSuitePerNight = 82;
            }
            else if (month == july || month == december || month == august)
            {
                priceForStudioPerNight = 68;
                priceForDoublePerNight = 77;
                priceForSuitePerNight = 89;
            }

            if (nightsCount > 7 && (month == may || month == october))
            {
                discountForStudio = 0.05;
            }
            else if (nightsCount > 14 && (month == june ||  month == september))
            {
                discountForDouble = 0.10;
            }
            else if (nightsCount > 14 && (month == july || month == august || month == december))
            {
                discountForSuite = 0.15;
            }

            if (nightsCount > 7 && (month == september || month == october))
            {
                discountForStudio *= priceForStudioPerNight;
                priceForStudioPerNight -= discountForStudio;
                totalPriceForStudio = priceForStudioPerNight * (nightsCount - 1);

                Console.WriteLine($"Studio: {totalPriceForStudio:f2} lv.");
            }
            else
            {
                discountForStudio *= priceForStudioPerNight;
                priceForStudioPerNight -= discountForStudio;
                totalPriceForStudio = priceForStudioPerNight * nightsCount;

                Console.WriteLine($"Studio: {totalPriceForStudio:f2} lv.");
            }           

            discountForDouble *= priceForDoublePerNight;
            priceForDoublePerNight -= discountForDouble;
            totalPriceForDouble = priceForDoublePerNight * nightsCount;

            Console.WriteLine($"Double: {totalPriceForDouble:f2} lv.");

            discountForSuite *= priceForSuitePerNight;
            priceForSuitePerNight -= discountForSuite;
            totalPriceForSuite = priceForSuitePerNight * nightsCount;

            Console.WriteLine($"Suite: {totalPriceForSuite:f2} lv.");


        }
    }
}
