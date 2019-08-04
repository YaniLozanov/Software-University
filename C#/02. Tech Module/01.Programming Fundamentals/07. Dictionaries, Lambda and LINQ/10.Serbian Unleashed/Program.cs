using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Admit it – the СРЪБСКО is your favorite sort of music.
            // You never miss a concert and you have become quite the geek concerning everything involved with Serbian Music.
            // You can’t decide between all the singers you know who your favorite one is.
            // One way to find out is to keep statistics of how much money their concerts make.
            // Write a program that does all the boring calculations for you.

            // On each input line you’ll be given data in format: "singer @venue ticketsPrice ticketsCount".
            // There will be no redundant whitespaces anywhere in the input.
            // Aggregate the data by venue and by singer. For each venue, print the singer and the total amount of money his/her concerts have made on a separate line.
            // Venues should be kept in the same order they were entered; the singers should be sorted by how much money they have made in descending order.
            // If two singers have made the same amount of money, keep them in the order in which they were entered. 

            // Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output.
            // Each of the four tokens must be separated by a space, everything else is invalid.
            // The venue should be denoted with @ in front of it, such as @Sunny Beach





            var dict = new Dictionary<string, Dictionary<string, BigInteger>>();

            string name = string.Empty;
            string place = string.Empty;
            long ticketsPrice = 0;
            long ticketsCount = 0;

            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                if (input[0] == "End")
                {
                    break;
                }

                if (4 <= input.Count && input.Count <= 8 &&
                    (input[1][0] == '@' || input[2][0] == '@' || input[3][0] == '@')
                    && ((long.TryParse(input[input.Count - 2], out ticketsCount))
                    && long.TryParse(input.Last(), out ticketsCount)))



                {
                    if (input[1][0] == '@')
                    {
                        if (48 <= input[2][0] && input[2][0] <= 57)
                        {
                            name = input[0];
                            place = input[1].Remove(0, 1);
                            ticketsPrice = long.Parse(input[2]);
                            ticketsCount = long.Parse(input[3]);
                        }
                        else if (48 <= input[3][0] && input[3][0] <= 57)
                        {
                            name = input[0];
                            place = input[1].Remove(0, 1) + " " + input[2];
                            ticketsPrice = long.Parse(input[3]);
                            ticketsCount = long.Parse(input[4]);
                        }
                        else if (48 <= input[4][0] && input[4][0] <= 57)
                        {
                            name = input[0];
                            place = input[1].Remove(0, 1) + " " + input[2] + " " + input[3];
                            ticketsPrice = long.Parse(input[4]);
                            ticketsCount = long.Parse(input[5]);
                        }
                    }
                    else if (input[2][0] == '@')
                    {
                        if (48 <= input[3][0] && input[3][0] <= 57)
                        {
                            name = input[0] + " " + input[1];
                            place = input[2].Remove(0, 1);
                            ticketsPrice = long.Parse(input[3]);
                            ticketsCount = long.Parse(input[4]);
                        }
                        else if (48 <= input[4][0] && input[4][0] <= 57)
                        {
                            name = input[0] + " " + input[1];
                            place = input[2].Remove(0, 1) + " " + input[3];
                            ticketsPrice = long.Parse(input[4]);
                            ticketsCount = long.Parse(input[5]);
                        }
                        else if (48 <= input[5][0] && input[5][0] <= 57)
                        {
                            name = input[0] + " " + input[1];
                            place = input[2].Remove(0, 1) + " " + input[3] + " " + input[4];
                            ticketsPrice = long.Parse(input[5]);
                            ticketsCount = long.Parse(input[6]);
                        }

                    }
                    else if (input[3][0] == '@')
                    {
                        if (48 <= input[4][0] && input[4][0] <= 57)
                        {
                            name = input[0] + " " + input[1] + " " + input[2];
                            place = input[3].Remove(0, 1);
                            ticketsPrice = long.Parse(input[4]);
                            ticketsCount = long.Parse(input[5]);
                        }
                        else if (48 <= input[5][0] && input[5][0] <= 57)
                        {
                            name = input[0] + " " + input[1] + " " + input[2];
                            place = input[3].Remove(0, 1) + " " + input[4];
                            ticketsPrice = long.Parse(input[5]);
                            ticketsCount = long.Parse(input[6]);
                        }
                        else if (48 <= input[6][0] && input[6][0] <= 57)
                        {
                            name = input[0] + " " + input[1] + " " + input[2];
                            place = input[3].Remove(0, 1) + " " + input[4] + " " + input[5];
                            ticketsPrice = long.Parse(input[6]);
                            ticketsCount = long.Parse(input[7]);
                        }
                    }


                    if (dict.ContainsKey(place) == false)
                    {
                        dict.Add(place, new Dictionary<string, BigInteger>());
                        dict[place].Add(name, (ticketsPrice * ticketsCount));
                    }
                    else
                    {
                        if (dict[place].ContainsKey(name) == false)
                        {
                            dict[place].Add(name, (ticketsPrice * ticketsCount));
                        }
                        else
                        {
                            dict[place][name] += (ticketsPrice * ticketsCount);
                        }
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var singer in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }



        }
    }
}
