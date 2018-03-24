using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    class Program
    {

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string stopWord = string.Empty;
            int bestResult = 0;
            int counter = 0;
            string[] bestDna = new string[] { };
            List<int> greater = new List<int>();
            int best = 0;
            int theBestSum = 0;
            int position = length + 1;
            int theBestPosition = 0;
            int simple = 0;
            int theBestSimple = 0;

            while (stopWord != "Clone them")
            {
                string[] input = Console.ReadLine().Split("!").ToArray();
                counter = 0;

                simple++;
                if (input[0] != "Clone them")
                {
                    for (int k = 0; k < length; k++)
                    {
                        best += int.Parse(input[k]);
                    }

                    for (int i = 0; i < length - 1; i++)
                    {
                        if (input[i] == input[i + 1] && input[i] == "1")
                        {
                            if (i < position)
                            {
                                position = i;
                            }

                            counter++;
                            if (bestResult < counter)
                            {
                                theBestPosition = position;

                                if (theBestSum < best)
                                {
                                    theBestSum = best;
                                }

                                theBestSimple = simple;
                                bestResult = counter;
                                bestDna = input;
                            }
                            else if (bestResult == counter)
                            {
                                if (theBestPosition > position)
                                {
                                    theBestSimple = simple;

                                    bestDna = input;
                                    theBestSum = best;
                                }
                            }

                        }
                    }
                }
                else
                {
                    stopWord = "Clone them";
                }
                best = 0;
            }

            Console.WriteLine($"Best DNA sample {theBestSimple} with sum:{theBestSum}");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
