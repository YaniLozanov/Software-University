using System;

namespace First
{
    class Program
    {
        //        Needed equipment for 2 padawans  :
        //sabresPrice* (studentsCount + 10%) + robesPrice* (studentsCount) + beltsPrice* (studentsCount-freeBelts) 
        //1*(3) + 2*(2) + 3*(2) = 13.00
        //13.00 <= 100 – the money will be enough.


        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeBelt = students / 6;

            double result = (saberPrice * (students + Math.Ceiling(students *0.1)) + (robePrice * (students)) + (beltPrice * (students - freeBelt)));

            double neededMoney = Math.Abs(result - money);

            if (result <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {result:f2}lv.");

            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}
