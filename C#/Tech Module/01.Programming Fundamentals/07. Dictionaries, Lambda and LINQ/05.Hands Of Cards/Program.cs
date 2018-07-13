using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem:
            // You are given a sequence of people and for every person what cards he draws from the deck.
            // The input will be separate lines in the format: {personName}:{ PT, PT, PT,… PT}

            // Where P(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T(S, H, D, C) is the type.
            // The input ends when a "JOKER" is drawn.The name can contain any ASCII symbol except ':'.
            // The input will always be valid and in the format described, there is no need to check it.

            // A single person cannot have more than one card with the same power and type, if they draw such a card they discard it.
            // The people are playing with multiple decks.
            // Each card has a value that is calculated by the power multiplied by the type.
            // Powers 2 to 10 have the same value and J to A are 11 to 14.
            // Types are mapped to multipliers the following way(S-> 4, H-> 3, D-> 2, C-> 1).

            // Finally print out the total value each player has in his hand in the format: {personName}:{value}

            



            var dict = new Dictionary<string, int>();
            var cardsPower = new Dictionary<char, int>()
            {
                {'2',2},
                {'3',3},
                {'4',4},
                {'5',5},
                {'6',6},
                {'7',7},
                {'8',8},
                {'9',9},
                {'1',10},
                {'J',11},
                {'Q',12},
                {'K',13},
                {'A',14},
            };
            var cardsType = new Dictionary<char, int>()
            {
                {'C', 1},
                {'D', 2},
                {'H', 3},
                {'S', 4}
            };
            var historyOfCards = new Dictionary<string, List<string>>();

            int points = 0;

            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { ',', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                if (input[0] == "JOKER")
                {
                    break;
                }

                if (historyOfCards.ContainsKey(input[0]) == false)
                {
                    historyOfCards.Add(input[0], new List<string>());

                    for (int i = 1; i < input.Count; i++)
                    {
                        historyOfCards[input[0]].Add(input[i]);
                    }
                }
                else
                {
                    for (int i = 1; i < input.Count; i++)
                    {
                        if (historyOfCards[input[0]].Contains(input[i]) == false)
                        {
                            historyOfCards[input[0]].Add(input[i]);
                        }
                        else
                        {
                            input.Remove(input[i]);
                            i--;
                        }
                    }
                }

                if (dict.ContainsKey(input[0]) == false)
                {
                    points = GiveThePoints(input, cardsPower, cardsType);

                    dict.Add(input[0], points);
                }
                else
                {
                    points = GiveThePoints(input, cardsPower, cardsType);
                    dict[input[0]] += points;
                }
            }

            foreach (var name in dict)
            {
                Console.WriteLine($"{name.Key}: {name.Value}");
            }

        }

        private static int GiveThePoints(List<string> input, Dictionary<char, int> cardsPower, Dictionary<char, int> cardsType)
        {
            string card = string.Empty;
            string power = string.Empty;
            string type = string.Empty;

            int points = 0;
            int powerPoints = 0;
            int typePoints = 0;


            for (int i = 1; i < input.Count; i++)
            {
                card = input[i];

                powerPoints = GivePowerPoints(card, cardsPower);
                typePoints = GiveTypePoints(card, cardsType);

                points += (powerPoints * typePoints);
            }
            return points;
        }

        private static int GiveTypePoints(string card, Dictionary<char, int> cardsType)
        {
            if (card.Length == 2)
            {
                int points = cardsType[card[1]];
                return points;

            }
            else
            {
                int points = cardsType[card[2]];
                return points;
            }
        }

        private static int GivePowerPoints(string card, Dictionary<char, int> cardsPower)
        {
            int points = cardsPower[card[0]];

            return points;
        }
    }
}
