
namespace Hello_Name
{
    using System;

    class Methods

    {
        public static void Main()
        {
            string name = Console.ReadLine();

            WriteHalloAndName(name);
        }

        public static void WriteHalloAndName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
