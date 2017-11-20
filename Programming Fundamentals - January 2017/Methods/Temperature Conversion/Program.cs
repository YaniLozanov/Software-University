
namespace Temperature_Conversion
{
    using System;

    class Methods
    {
        public static void Main()
        {
            var temperatureInFahrenheit = decimal.Parse(Console.ReadLine());

            ConvertFahrenheitToCelsius(temperatureInFahrenheit);

        }

        public static void ConvertFahrenheitToCelsius(decimal temperatureInFahrenheit)
        {
            decimal temperatureInCelsius = (temperatureInFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{temperatureInCelsius:f2}");
        }
    }
}
