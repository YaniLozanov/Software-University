using System;
using System.Collections.Generic;
using System.Linq;



namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)

        {

            // Problem:
            // Marian is a famous system administrator.
            // The person to overcome the security of his servers has not yet been born. However, there is a new type of threat where users flood the server with messages and are hard to be detected since they change their IP address all the time.
            // Well, Marian is a system administrator and is not so into programming.
            // Therefore, he needs a skillful programmer to track the user logs of his servers.
            // You are the chosen one to help him!

            // You are given an input in the format:
            // IP = (IP.Address)message = (A & sample & message) user = (username)

            // Your task is to parse the IP and the username from the input and for every user, you have to display every IP from which the corresponding user has sent a message and the count of the messages sent with the corresponding IP.
            // In the output, the usernames must be sorted alphabetically while their IP addresses should be displayed in the order of their first appearance.
            // The output should be in the following format:

            // username: 
            // IP => count, IP => count.









            var dict = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { ' ', '=' }).ToList();

                if (input[0] == "end")
                {
                    break;
                }

                if (dict.ContainsKey(input[input.Count - 1]) == false)
                {
                    dict.Add(input[input.Count - 1], new Dictionary<string, int>());
                    dict[input[input.Count - 1]].Add(input[1], 1);
                }
                else
                {
                    if (dict[input[input.Count - 1]].ContainsKey(input[1]))
                    {
                        dict[input[input.Count - 1]][input[1]]++;
                    }
                    else
                    {
                        dict[input[input.Count - 1]].Add(input[1], 1);
                    }

                }
            }

            int counter = 1;
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: ");

                foreach (var element in item.Value)
                {


                    if (item.Value.Count == counter)
                    {
                        Console.Write($"{element.Key} => {element.Value}.");

                    }
                    else
                    {
                        Console.Write($"{element.Key} => {element.Value}, ");
                    }

                    counter++;
                }
                counter = 1;
                Console.WriteLine();
            }

        }
    }
}
