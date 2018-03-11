using System;

namespace Мax_Method
{
    class Program
    {
        //Problem:
        // Create a method GetMax(int a, int b), that returns the largest of two numbers.
        // Write a program that reads three numbers from the console and prints the biggest of them.
        // Use the GetMax(…) method you just created.


        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

             GetMaxNumber(firstNum, secondNum, thirdNum);

            

        }

        static void GetMaxNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum >= secondNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
            else if (secondNum > firstNum)
            {
                if (secondNum >= thirdNum)
                {
                    Console.WriteLine(secondNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
            
                
            
            
        }
    }
}
