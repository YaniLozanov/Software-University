using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // A hotel has three types of rooms: studio, double and master suite. The prices are different for the different months: 
            // |May and October                 |June and September             | July, August and December
            // |Studio - 50 leva per night      |Studio -60 leva per night      |Studio -68 leva per night
            // |Double - 65 leva per night      |Double -72 leva per night      |Double -77 leva per night
            // |Suite - 75 leva per night       |Suite -82 leva per night       |Suite -89 leva per night
            // They have also the following discounts:
            // For studio and more than 7 nights in May and October: 5 % discount
            // For double and more than 14 nights in June and September: 10 % discount
            // For suite and more than 14 nights in July, August and December: 15 % discount
            // For studio and more than 7 nights in September and October: one night is free


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
            else if (nightsCount > 14 && (month == june || month == september))
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

