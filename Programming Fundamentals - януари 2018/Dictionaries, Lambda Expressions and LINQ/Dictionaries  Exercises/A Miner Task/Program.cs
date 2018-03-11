using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int length =  int.Parse(Console.ReadLine());

            string[] bestDna = new string[] { };
            string stopWord = string.Empty;
            int theBiggestSum = 0;
            int sum = 0;
            int counter = 0;
            int theBestCount = 0;
            int position = length + 1;
            int theBestPositon= 1;
            int simple = 0;
            int theBestSimple = 0;
            

            while (stopWord != "Clone them")
            {
                string[] input = Console.ReadLine().Split(new char[] {'!'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                stopWord = input[0];
                if (input[0] != "Clone them")
                {
                    sum = GiveTheSum(input);
                    simple++;
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        if ( input[i] == "1" && input[i + 1] == "1")
                        {
                            counter++;

                            if (i <= position)
                            {
                                position = i;
                            }

                            if (theBestCount < counter)
                            {
                                theBestCount = counter;
                                bestDna = input;
                                theBiggestSum = sum;
                                theBestPositon = position;
                                theBestSimple = simple;
                            }
                            else if (theBestCount == counter == theBestPositon > position)
                            {

                                theBestPositon = position;
                                bestDna = input;
                                theBiggestSum = sum;
                                theBestSimple = simple;

                            }
                            else if (theBestCount == counter && theBestPositon == position && sum > theBiggestSum)
                            {
                                theBiggestSum = sum;
                                bestDna = input;
                                theBestSimple = simple;
                            }
                    
                            
                            
                        }

                        
                    }
                    counter = 0;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine($"Best DNA sample {theBestSimple} with sum: {theBiggestSum}.");
            Console.WriteLine(string.Join(" ",bestDna));
        }

        private static int GiveTheSum(string[] input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i]); 
            }
            return sum;
        }
    }
}
