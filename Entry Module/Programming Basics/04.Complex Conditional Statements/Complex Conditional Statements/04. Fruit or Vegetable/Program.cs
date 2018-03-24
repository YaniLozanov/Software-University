using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();

            var fruit = product == "banana" ||
                        product == "apple" ||
                        product == "kiwi" ||
                        product == "cherry" ||
                        product == "lemon" ||
                        product == "grapes";

            var vegetable = product == "tomato" ||
                            product == "cucumber" ||
                            product == "pepper" ||
                            product == "carrot";

            if (fruit)
            {
                Console.WriteLine("fruit");
            }
            else if (vegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
