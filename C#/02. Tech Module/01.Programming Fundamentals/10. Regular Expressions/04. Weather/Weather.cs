using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Weather
{
    class Weather
    {
        // Problem:
        // You have to make a weather forecast about the weather depending on strings, which you receive from the console.Every string consists of data about the city, average temperature and weather type.
        // You will receive strings until you receive the command “end”. 
        // Every valid weather forecast consists of:
        // Two Latin capital letters, which represent the code of the city
        // Immediately followed by a floating-point number, which will represent the average temperature. Numbers without a floating point are not considered valid.
        // Followed by the type of weather, which will consist of uppercase and lowercase Latin letters, starts immediately after the temperature and ends at the first occurrence of the sign ‘|’
        // If you receive input, which does not follow the rules above – ignore it.
        // If you receive a new temperature and/or type of weather for a city, which already exists – rewrite the previous values.
        // At the end, print the temperature and weather type for every city.
        // Order the cities by average temperature in ascending order.

        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d{1,2}\.\d{1,2})([A-Za-z]+)\|";

            var dataOfCities = new Dictionary<string, Dictionary<double, string>> { }; // Cityes Name, Average Temeperature, Type of the Weather.

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "end")
                {
                    break;
                }

                MatchCollection matches = Regex.Matches(text, pattern);

                foreach (Match match in matches)
                {
                    string citiesName = match.Groups[1].ToString();
                    string averageTemperatureToString = match.Groups[2].ToString();             // First i parsed it to string.
                    double averageTemperature = double.Parse(averageTemperatureToString);       // Second i parsed it to float
                    string typeOfTheWeaher = match.Groups[3].ToString();

                    if (dataOfCities.ContainsKey(citiesName) == false) // Check whether  we  have the citis name already.
                    {
                        dataOfCities.Add(citiesName, new Dictionary<double, string>()); // Add cities.
                        dataOfCities[citiesName].Add(averageTemperature, typeOfTheWeaher);
                    }
                    else
                    {
                        dataOfCities[citiesName] = new Dictionary<double, string>() { { averageTemperature, typeOfTheWeaher } }; // Refresh the data: Average temperature and type of the weather.
                    }
                }
            }

            foreach (var city in dataOfCities.OrderBy(x => x.Value.Sum(y => y.Key))) //  The averge temperature in ascending order and print the data.
            {

                foreach (var data in city.Value)
                {
                    Console.WriteLine($"{city.Key} => {data.Key:f2} => {data.Value}");
                }
            }
        }
    }
}
