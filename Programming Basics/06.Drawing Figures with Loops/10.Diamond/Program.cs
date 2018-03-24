using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            char asterix = '*';
            char minuses = '-';

            int countOfAsterix = 1;

            if (size % 2 == 0)
            {
                countOfAsterix = 2;
            }

            int countOfMinuses = (size - countOfAsterix) / 2;

            string topAndBotRow = string.Format("{0}{1}{0}", new string(minuses, countOfMinuses),
                                                            new string(asterix, countOfAsterix));
            Console.WriteLine(topAndBotRow);

            int toralRows = size;
            if (size % 2 == 0)
            {
                size--;
            }

            int topRows = (size - 1) / 2;
            int countOfMiddleDasches = countOfAsterix;

            for (int currentRow = 0; currentRow < topRows; currentRow++)
            {
                countOfMinuses--;

                string sideDashes = new string(minuses, countOfMinuses);
                string middleDashes = new string(minuses, countOfMiddleDasches);
                countOfMiddleDasches += 2;
                Console.WriteLine("{0}*{1}*{0}", sideDashes, middleDashes);
            }

            int bottomPart = topRows - 1;
            countOfMiddleDasches -= 2;
            for (int currencyRow = 1; currencyRow <= bottomPart; currencyRow++)
            {
                countOfMiddleDasches -= 2;
                string sideDashes = new string(minuses, currencyRow);
                string middleDashes = new string(minuses, countOfMiddleDasches);

                Console.WriteLine("{0}*{1}*{0}", sideDashes, middleDashes);
            }

            if (size > 2)
            {
                Console.WriteLine(topAndBotRow);
            }
        }
    }
}
