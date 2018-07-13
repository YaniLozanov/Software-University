using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // All the data is quite tedious, so he would like to have a program doing it.
            // Since he is no Heroes III is the best game ever. Everyone loves it and everyone plays it all the time.
            // Stamat is no exclusion to this rule.
            // His favorite units in the game are all types of dragons – black, red, gold, azure etc… He likes them so much that he gives them names and keeps logs of their stats: damage, health and armor.
            // The process of aggregating programmer, it’s your task to help him


            // You need to categorize dragons by their type.
            // For each dragon, identified by name, keep information about his stats.
            // Type is preserved as in the order of input, but dragons are sorted alphabetically by name.
            // For each type, you should also print the average damage, health and armor of the dragons.
            // For each dragon, print his own stats.
            // There may be missing stats in the input, though.
            // If a stat is missing you should assign it default values.
            // Default values are as follows: health 250, damage 45, and armor 10.
            // Missing stat will be marked by null.

            // The input is in the following format {type} {name} {damage} {health} {armor}.
            // Any of the integers may be assigned null value.
            // See the examples below for better understanding of your task.
            // If the same dragon is added a second time, the new stats should overwrite the previous ones.
            // Two dragons are considered equal if they match by both name and type.




            List<string> input = Console.ReadLine().Split(' ').ToList();


            var dragonsData = new Dictionary<string, SortedDictionary<string, List<int>>>();
            var averegeStatus = new Dictionary<string, List<double>>();

            int counter = int.Parse(input[0]);

            bool validInput = false;


            for (int i = 1; i <= counter; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();

                validInput = CheckTheInput(input);

                if (validInput)
                {
                    if (dragonsData.ContainsKey(input[0]) == false)
                    {
                        if (input[2] == "null")
                        {
                            input[2] = "45";
                        }

                        if (input[3] == "null")
                        {
                            input[3] = "250";
                        }

                        if (input[4] == "null")
                        {
                            input[4] = "10";
                        }

                        dragonsData.Add(input[0], new SortedDictionary<string, List<int>>());

                        dragonsData[input[0]].Add(input[1], new List<int>());
                        dragonsData[input[0]][input[1]].AddRange(new List<int>() { int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]) });
                    }
                    else
                    {
                        if (dragonsData[input[0]].ContainsKey(input[1]) == false)
                        {
                            if (input[2] == "null")
                            {
                                input[2] = "45";
                            }

                            if (input[3] == "null")
                            {
                                input[3] = "250";
                            }

                            if (input[4] == "null")
                            {
                                input[4] = "10";
                            }

                            dragonsData[input[0]].Add(input[1], new List<int>());
                            dragonsData[input[0]][input[1]].AddRange(new List<int>() { int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]) });
                        }
                        else
                        {
                            if (input[2] == "null")
                            {
                                input[2] = "45";
                            }

                            if (input[3] == "null")
                            {
                                input[3] = "250";
                            }

                            if (input[4] == "null")
                            {
                                input[4] = "10";
                            }

                            dragonsData[input[0]][input[1]].Clear();
                            dragonsData[input[0]][input[1]].AddRange(new List<int>() { int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]) });
                        }
                    }
                }
            }


            foreach (var type in dragonsData)
            {
                averegeStatus.Add(type.Key, new List<double>());

                double averageDamage = 0;
                double averageArmor = 0;
                double averageHealth = 0;
                double dragonsNum = 0;

                foreach (var dragon in type.Value)
                {
                    dragonsNum++;
                    averageDamage += dragon.Value[0];
                    averageHealth += dragon.Value[1];
                    averageArmor += dragon.Value[2];
                }

                averageDamage /= dragonsNum;
                averageHealth /= dragonsNum;
                averageArmor /= dragonsNum;

                averegeStatus[type.Key].AddRange(new List<double> { averageDamage, averageHealth, averageArmor });
            }

            foreach (var type in dragonsData)
            {


                Console.WriteLine($"{type.Key}::({averegeStatus[type.Key][0]:f2}/{averegeStatus[type.Key][1]:f2}/{averegeStatus[type.Key][2]:f2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }

        private static bool CheckTheInput(List<string> input)
        {
            int ignore;

            bool type = 65 <= input[0][0] && input[0][0] <= 90;
            bool name = 65 <= input[0][0] && input[0][0] <= 90;
            bool damage = int.TryParse(input[2], out ignore) || (input[2] == "null");
            bool health = int.TryParse(input[3], out ignore) || (input[3] == "null");
            bool armor = int.TryParse(input[4], out ignore) || (input[4] == "null");

            bool validInput = type && name && damage && health && armor;

            return validInput;
        }
    }
}
