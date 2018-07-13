using System;
using System.Collections.Generic;
using System.Linq;


namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problems:
            // You are given a sequence of access logs in format <IP> <user> <duration>.

            // Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]".
            // Order the users alphabetically.
            // Order the IPs alphabetically.

            List<string> input = Console.ReadLine().Split(' ').ToList();

            var dict = new SortedDictionary<string, SortedDictionary<string, int>>();

            int lines = int.Parse(input[0]);


            for (int i = 0; i < lines; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();

                if (dict.ContainsKey(input[1]) == false)
                {
                    dict.Add(input[1], new SortedDictionary<string, int>());

                    dict[input[1]].Add(input[0], int.Parse(input[2]));
                }
                else
                {
                    if (dict[input[1]].ContainsKey(input[0]) == false)
                    {
                        dict[input[1]].Add(input[0], int.Parse(input[2]));
                    }
                    else
                    {
                        dict[input[1]][input[0]] += int.Parse(input[2]);
                    }
                }
            }

            int duration = 0;
            int counter = 1;
            foreach (var item in dict)
            {
                foreach (var num in item.Value)
                {
                    duration += num.Value;
                }

                Console.Write($"{item.Key}: {duration} ");
                duration = 0;
                Console.Write("[");
                foreach (var ip in item.Value)
                {
                    if (counter < item.Value.Count)
                    {
                        Console.Write($"{ip.Key}, ");

                    }
                    else
                    {
                        Console.Write($"{ip.Key}");

                    }
                    counter++;
                }
                Console.WriteLine("]");
                counter = 1;
            }
        }
    }
}
