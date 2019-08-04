using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // You are given a sequence of strings, each on a new line, until you receive the “stop” command.
            // The first string is the name of a person. On the second line, you will receive their email.
            // Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive).
            // Print: {name} –> {email} 

            var notebook = new SortedDictionary<string, string>();

            string[] email = new string[] { };
            string name = string.Empty;

            while (true)
            {
                name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                email = Console.ReadLine().Split('.').ToArray();





                if (notebook.ContainsKey(name) == false && email[1] != "us" && email[1] != "uk")
                {
                    notebook.Add(name, (email[0] + "." + email[1]));
                }
                else
                {
                    if (email[1] != "us" && email[1] != "uk")
                    {
                        notebook[name] = (email[0] + "." + email[1]);
                    }
                }

            }

            foreach (var item in notebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
