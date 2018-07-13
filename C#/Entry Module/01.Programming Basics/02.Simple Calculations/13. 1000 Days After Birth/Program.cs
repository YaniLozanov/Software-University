using System;
using System.Globalization;

namespace Data_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();

            DateTime in1000Dayis = DateTime.ParseExact(inputDate, "dd-MM-yyyy",
            CultureInfo.InvariantCulture).AddDays(999);

            Console.WriteLine(in1000Dayis.ToString("dd-MM-yyyy"));
        }
    }
}
