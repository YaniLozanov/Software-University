using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when receive the command “ListAll”.


            var phonebook = new Dictionary<string, string>();
            var commands = new List<string>();

            string stopWord = string.Empty;

            while (stopWord != "END")
            {
                commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "A")
                {
                    if (phonebook.ContainsKey(commands[1]) == false)
                    {
                        phonebook.Add(commands[1], commands[2]);
                    }
                    else
                    {
                        phonebook[commands[1]] = commands[2];
                    }
                }
                else if (commands[0] == "S")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                }
                else if (commands[0] == "ListAll")
                {

                    foreach (var name in phonebook.OrderBy(pair => pair.Key))
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                }
                else
                {
                    stopWord = commands[0];
                }

            }

        }
    }
}




