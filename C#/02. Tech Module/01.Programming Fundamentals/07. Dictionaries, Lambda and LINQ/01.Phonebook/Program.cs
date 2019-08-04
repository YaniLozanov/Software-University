using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // Write a program that receives some info from the console about people and their phone numbers.
            // Each entry should have just one name and one number (both of them strings). 
            // On each line, you will receive some of the following commands:

            // A {name} {phone} – adds entry to the phonebook.
            // In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.

            // S {name} – searches for a contact by given name and prints it in format "{name} -> {number}".
            // In case the contact isn't found, print "Contact {name} does not exist.".

            // END – stop receiving more commands.
          

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
                else
                {
                    stopWord = commands[0];
                }

            }

        }
    }
}
