using System;

namespace Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Create a program that assigns integer values to variables.
            // Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). 
            // Finally, you need to print all variables to the console.


            sbyte firstNum = -100;
            byte secondNum = 128;
            short thirdNum = -3540;
            int fourthNum = 64876;
            uint fifthNum = 2147483648;
            long sixthNum = -1141583228;
            long seventhNum = -1223372036854775808;


            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirdNum);
            Console.WriteLine(fourthNum);
            Console.WriteLine(fifthNum);
            Console.WriteLine(sixthNum);
            Console.WriteLine(seventhNum);

        }
    }
}

