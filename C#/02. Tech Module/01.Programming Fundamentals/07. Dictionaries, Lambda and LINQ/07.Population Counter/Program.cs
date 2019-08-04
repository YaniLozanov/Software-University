using System;
using System.Collections.Generic;
using System.Linq;


namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            //  So many people! It’s hard to count them all.
            // But that’s your job as a statistician. 
            // You get raw data for a given city and you need to aggregate it. 

            // On each input line, you’ll be given data in format: "city|country|population".
            // There will be no redundant whitespaces anywhere in the input.
            // Aggregate the data by country and by city and print it on the console. 

            // For each country, print its total population and on separate lines, the data for each of its cities.
            // Countries should be ordered by their total population in descending order and within each country, the cities should be ordered by the same criterion.

            // If two countries/cities have the same population, keep them in the order in which they were entered.
            // Check out the examples; follow the output format strictly!

            var country = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split('|').ToList();

                if (input[0] == "report")
                {
                    break;
                }

                if (country.ContainsKey(input[1]) == false)
                {
                    country.Add(input[1], new Dictionary<string, long>());

                    country[input[1]].Add(input[0], long.Parse(input[2]));
                }
                else
                {
                    if (country[input[1]].ContainsKey(input[0]) == false)
                    {
                        country[input[1]].Add(input[0], long.Parse(input[2]));
                    }
                    else
                    {
                        country[input[1]][input[0]] += long.Parse(input[2]);
                    }
                }
            }

            foreach (var item in country.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Sum(x => x.Value)})");

                foreach (var town in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }

        }
    }
}
