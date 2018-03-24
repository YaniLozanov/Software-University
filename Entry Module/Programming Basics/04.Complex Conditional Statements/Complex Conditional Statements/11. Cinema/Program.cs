using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipe = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var price = 0.0;

            switch (tipe)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0:f2}", price * r * c + " " + "leva");
        }
    }
}

