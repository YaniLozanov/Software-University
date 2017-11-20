
namespace Max_Method
{
    using System;

    class Methods
    {
        static void Main()
        {
            int fistNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            int theBiggestNum = GetMax(fistNum, secondNum, thirdNum);

            Console.WriteLine(theBiggestNum);

        }

        public static int GetMax(int firstNum,int secondNumm,int thirdNum)
        {
            int result = 0;

            if (firstNum > secondNumm)
            {
                if (firstNum > thirdNum)
                {
                    result = firstNum;
                }
                else
                {
                    result = thirdNum;
                }
            }
            else
            {
                if (secondNumm > thirdNum)
                {
                    result = secondNumm;
                }
                else
                {
                    result = thirdNum;
                }
            }

            return result;
        }
    }
}
