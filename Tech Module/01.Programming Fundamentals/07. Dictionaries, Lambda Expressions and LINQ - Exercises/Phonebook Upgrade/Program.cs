using System;
using System.Linq;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        // Problem:
        // Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when receive the command “ListAll”.

        static void Main(string[] args)
        {
            string[] input;

            var phonebook = new SortedDictionary <string, string>();
            string stopWord = string.Empty;

            while (stopWord != "END")
            {
                input = Console.ReadLine().Split().ToArray();
                stopWord = input[0];

                if (input[0] == "A")
                {
                    // Adds entry to the phonebook.
                    AddTheContact(input, phonebook);
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        // Searches for a contact by given name and prints it.
                        PrintTheContact(input, phonebook);
                    }
                    else
                    {
                        // Doesn`t found the contact , print a message :"Contact {name} does not exist."
                        PrintAnMessage(input);
                    }
                }
                else if (input[0] == "ListAll")
                {
                    // Print all contacts in the phonebook.
                    PrintAllContacts(phonebook);
                }
            }
        }

        private static void PrintAllContacts(SortedDictionary<string, string> phonebook)
        {
            foreach (var contact in phonebook)
            {
                Console.WriteLine("{0} -> {1}",contact.Key,contact.Value);
            }
        }

        private static void PrintAnMessage(string[] input)
        {
            Console.WriteLine($"Contact {input[1]} does not exist.");
        }

        private static void PrintTheContact(string[] input, SortedDictionary<string, string> phonebook)
        {
            foreach (var contact in phonebook)
            {
                if (contact.Key == input[1])
                {
                    Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                }
            }
        }

        private static void AddTheContact(string[] input, SortedDictionary<string, string> phonebook)
        {
            if (phonebook.ContainsKey(input[1]))
            {
                phonebook[input[1]] = input[2];
            }
            else
            {
                phonebook.Add(input[1], input[2]);
            }
        }
    }
}
