using System;
using System.Collections.Generic;


namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // You are given a sequence of strings, each on a new line.
            // Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity.
            // Your task is to collect the resources and print them each on a new line. 
            // Print the resources and their quantities in format:

            //{resource} –> {quantity}

            // The quantities inputs will be in the range[1 … 2 000 000 000]


            var resources = new Dictionary<string, int>();

            int counter = 1;
            string stopWord = string.Empty;


            string resourcesName = string.Empty;
            int quantity = 0;

            while (true)
            {
                if (counter % 2 != 0)
                {
                    resourcesName = Console.ReadLine();
                    stopWord = resourcesName;

                    if (stopWord == "stop")
                    {
                        break;
                    }
                }
                else
                {
                    quantity = int.Parse(Console.ReadLine());
                }

                if (resources.ContainsKey(resourcesName) == false)
                {
                    resources.Add(resourcesName, 0);
                }
                else
                {
                    resources[resourcesName] += quantity;
                    quantity = 0;
                }

                counter++;

            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }

        }
    }
}
