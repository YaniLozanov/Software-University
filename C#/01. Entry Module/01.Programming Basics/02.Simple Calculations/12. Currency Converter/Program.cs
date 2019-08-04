using System;


namespace Currency_Converter2
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine().ToUpper();
            string currency2 = Console.ReadLine().ToUpper();
            double result;

            if (currency1 == "BGN")
            {

                if (currency2 == "USD")
                {
                    result = input / 1.79549;
                    Console.WriteLine(Math.Round(result, 2) + " USD");
                }
                else if (currency2 == "GBP")
                {
                    result = input / 2.53405;
                    Console.WriteLine(Math.Round(result, 2) + " GBP");
                }
                else if (currency2 == "EUR")
                {
                    result = input / 1.95583;
                    Console.WriteLine(Math.Round(result, 2) + " EUR");
                }

            }

            else if (currency1 == "USD")
            {
                if (currency2 == "BGN")
                {
                    result = input * 1.79549;
                    Console.WriteLine(Math.Round(result, 2) + " BGN");
                }
                else if (currency2 == "GBP")
                {
                    result = (input * 1.79549) / 2.53405;
                    Console.WriteLine(Math.Round(result, 2) + " GBP");
                }
                else if (currency2 == "EUR")
                {
                    result = (input * 1.79549) / 1.95583;
                    Console.WriteLine(Math.Round(result, 2) + " EUR");
                }
            }
            else if (currency1 == "EUR")
            {
                if (currency2 == "BGN")
                {
                    result = input * 1.95583;
                    Console.WriteLine(Math.Round(result, 2) + " BGN");
                }
                else if (currency2 == "GBP")
                {
                    result = (input * 1.95583) / 2.53405;
                    Console.WriteLine(Math.Round(result, 2) + " GBP");
                }
                else if (currency2 == "USD")
                {
                    result = (input * 1.95583) / 1.79549;
                    Console.WriteLine(Math.Round(result, 2) + " USD");
                }
            }
            else if (currency1 == "GBP")
            {
                if (currency2 == "BGN")
                {
                    result = input * 2.53405;
                    Console.WriteLine(Math.Round(result, 2) + " BGN");
                }
                else if (currency2 == "USD")
                {
                    result = (input * 2.53405) / 1.79549;
                    Console.WriteLine(Math.Round(result, 2) + " USD");
                }
                else if (currency2 == "EUR")
                {
                    result = (input * 2.53405) / 1.95583;
                    Console.WriteLine(Math.Round(result, 2) + " EUR");
                }
            }
        }
    }
}