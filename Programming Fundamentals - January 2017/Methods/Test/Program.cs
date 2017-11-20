
namespace Test
{
    using System;


    class Methods

    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceipBody();
            PrintReceipFooter();
        }
        
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceipBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceipFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9"+" SoftUni");
        }
    }
}
