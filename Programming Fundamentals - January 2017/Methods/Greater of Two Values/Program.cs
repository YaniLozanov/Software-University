

namespace Greater_of_Two_Values
{
    using System;

    class Methods
    {
        public static void Main()
        {
            string type = Console.ReadLine();
        

         
            if (type == "int")
            {
                var firstInput = int.Parse(Console.ReadLine());
                var secondInput = int.Parse(Console.ReadLine());
                var greaterVolue = GetMax(firstInput, secondInput);
                Console.WriteLine(greaterVolue);
            }
            else if (type == "char")
            {
                var firstInput = char.Parse(Console.ReadLine());
                var secondInput = char.Parse(Console.ReadLine());
                var greaterVolue = GetMax(firstInput, secondInput);
                Console.WriteLine(greaterVolue);

            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                var greaterVolue = GetMax(firstInput, secondInput);
                Console.WriteLine(greaterVolue);
            }

            

        }

        public static int GetMax(int fisrtInput, int secondInput)
        {
            if (fisrtInput > secondInput)
            {
                return fisrtInput;
            }
            else
            {
                return secondInput;
            }      
        }

        public static char GetMax(char fistInput , char secondInput)
        {
            if (fistInput > secondInput)
            {
                return fistInput;
            }
            else
            {
                return secondInput;
            }
        }

        public static string GetMax(string fistInput , string secondInput)
        {
            if (fistInput.CompareTo(secondInput) >= 0)
            {
                return fistInput;
            }
            else
            {
                return secondInput;
            }
        }

      
    }
}
