using System;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith('y'))
            {
                word = word.Remove(word.Length - 1);
                word = word + "ies";

            }
            else if (word.EndsWith('o') || word.EndsWith('s') || word.EndsWith('x') || word.EndsWith('z') || (word.EndsWith('h') && (word[word.Length - 2] == 'c') || word[word.Length - 2] == 's'))
            {
                word = word.Remove(word.Length - 1);
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }

            Console.WriteLine(word);

        }
    }
}
