using System;

class WordInPlural
{
    static void Main()
    {
        // Problem:
        // Write a program, which receives a noun and prints the noun in plural. You will receive one of the following cases: 
        // A noun that ends in y – remove the y and add ies
        // A noun that ends in o, ch, s, sh, x or z – add es at the end of the word
        // In all other cases – just add s at the end


        string word = Console.ReadLine();
        char one = word[word.Length - 1];
        char two = word[word.Length - 2];
        if (one == 'y')
        {
            word = word.Remove(word.Length - 1);
            Console.WriteLine(word + "ies");
        }
        else if (one == 'o' || one == 's' || one == 'x' || one == 'z' || (one == 'h' && two == 'c' || two == 's'))
        {
            Console.WriteLine(word + "es");
        }
        else
        {
            Console.WriteLine(word + "s");
        }
    }
}