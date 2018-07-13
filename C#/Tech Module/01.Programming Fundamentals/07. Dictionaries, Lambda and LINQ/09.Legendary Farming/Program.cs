using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // You’ve beaten all the content and the last thing left to accomplish is own a legendary item.
            // However, it’s a tedious process and requires quite a bit of farming.
            // Anyway, you are not too pretentious – any legendary will do.
            // The possible items are:

            // Shadowmourne – requires 250 Shards;
            // Valanyr – requires 250 Fragments;
            // Dragonwrath – requires 250 Motes;

            // Shards, Fragments and Motes are the key materials, all else is junk.
            // You will be given lines of input, such as 2 motes 3 ores 15 stones.
            // Keep track of the key materials -the first that reaches the 250 mark wins the race.
            // At that point, print the corresponding legendary obtained.Then, print the remaining shards, fragments, motes, ordered by quantity in descending order, then by name in ascending order, each on a new line.
            // Finally, print the collected junk items, in alphabetical order.




            var dict = new SortedDictionary<string, int>()
            {
                {"motes",0},
                {"fragments",0},
                {"shards",0}

            };

            int quantity = 0;
            string stopword = string.Empty;

            while (stopword != "Shadowmourne" && stopword != "Valanyr" && stopword != "Dragonwrath")
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                for (int i = 1; i <= input.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        quantity = int.Parse(input[i - 1]);
                    }
                    else
                    {
                        if (dict.ContainsKey(input[i - 1].ToLower()) == false)
                        {
                            dict.Add(input[i - 1].ToLower(), quantity);
                        }
                        else
                        {
                            dict[input[i - 1].ToLower()] += quantity;
                        }
                    }

                    if (dict.ContainsKey("motes"))
                    {
                        if (dict["motes"] >= 250)
                        {
                            dict["motes"] -= 250;
                            stopword = "Dragonwrath";
                            break;
                        }
                    }

                    if (dict.ContainsKey("fragments"))
                    {
                        if (dict["fragments"] >= 250)
                        {
                            dict["fragments"] -= 250;
                            stopword = "Valanyr";
                            break;
                        }
                    }

                    if (dict.ContainsKey("shards"))
                    {
                        if (dict["shards"] >= 250)
                        {
                            dict["shards"] -= 250;
                            stopword = "Shadowmourne";
                            break;
                        }
                    }
                }
            }


            Console.WriteLine($"{stopword} obtained!");

            foreach (var item in dict.Where(x => x.Key == "motes" || x.Key == "shards" || x.Key == "fragments").OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in dict.Where(x => x.Key != "motes" && x.Key != "shards" && x.Key != "fragments").OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }

        }
    }
}
