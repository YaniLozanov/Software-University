using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fix_Emails
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int numOfMessages =   int.Parse(Console.ReadLine());


           
            int key = 0;
            List<char> decryptedMessage = new List<char>();
            
            string decrypttedMinString;
            string planetsNamePatter = @"(?<=@)[A-Z][a-z]+";
            string atackPattern = @"(?<=!)[!A!]";
            string destruktionPattern = @"(?<=!)[!D!]";
            string soldersPattern = @"(?<=->)\d+";
            string populationPattern = @"(?<=:)\d+";
            int counterAtack = 0;
            int counterDestruction = 0;

            Regex population = new Regex(populationPattern);
            Regex solders = new Regex(soldersPattern);
            Regex planetNameRegex = new Regex(planetsNamePatter);
            Regex atack = new Regex(atackPattern);
            Regex destruktion = new Regex(destruktionPattern);
            

            List<string> names = new List<string>();
            List<string> destroyedNames = new List<string>();


            MatchCollection planetsName;

            for (int i = 0; i < numOfMessages; i++)
            {
                List<char> message = new List<char>();
                message = Console.ReadLine().ToList();

                key = GiveTheKey(message);

                DecryptedTheMessage(message, key, decryptedMessage);

                decrypttedMinString = string.Join("", decryptedMessage);
                

                planetsName = planetNameRegex.Matches(decrypttedMinString);

                

                foreach (var item in planetsName)
                {
                    if (planetNameRegex.IsMatch(decrypttedMinString) && atack.IsMatch(decrypttedMinString) && solders.IsMatch(decrypttedMinString)
                        && population.IsMatch(decrypttedMinString))
                    {
                        counterAtack++;
                        names.Add(item.ToString());
                    }
                    else if (planetNameRegex.IsMatch(decrypttedMinString) && destruktion.IsMatch(decrypttedMinString) && solders.IsMatch(decrypttedMinString)
                        && population.IsMatch(decrypttedMinString))
                    {
                        counterDestruction++;
                        destroyedNames.Add(item.ToString());
                    }                  
                }
                decrypttedMinString = string.Empty;

                for (int k = 0; k < decryptedMessage.Count; k++)
                {
                    decryptedMessage.RemoveAt(k);
                    k = 0;
                }                               
            }
            names.Sort();         
            Console.WriteLine($"Attacked planets: {counterAtack}");
            foreach (var item in names)
            {
                Console.WriteLine($"-> {item}");
            }

            destroyedNames.Sort();
            Console.WriteLine($"Destroyed planets: {counterDestruction}");
            foreach (var item in destroyedNames)
            {
                Console.WriteLine($"-> {item}");
            }          
        }

        private static void DecryptedTheMessage(List<char> message, int key, List<char> decryptedMessage)
        {
            int some = 0;
            for (int i = 0; i < message.Count; i++)
            {
              some = message[i] - (char)key;
                decryptedMessage.Add((char)some);
            }          
        }

        private static int GiveTheKey(List<char> message)
        {
            int count = 0;
           
            for (int i = 0; i < message.Count; i++)
            {
              

                if (message[i] == 's' || message[i] == 't' ||
                    message[i] == 'a' || message[i] == 'r'||
                    message[i] == 'S' || message[i] == 'T' ||
                    message[i] == 'A' || message[i] == 'R' )
                {
                    count++;
                }
            }

            return count;
        }
    }
}
