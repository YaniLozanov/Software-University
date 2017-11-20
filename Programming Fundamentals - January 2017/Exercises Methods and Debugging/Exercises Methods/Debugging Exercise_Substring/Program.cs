using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        int  Search = 112;
        bool hasMatch = false;
        int check = 0;

        for (int i = 0; i < text.Length; i++)
        {
            check = 0;
            string something = text.Substring(i, 1);

            if (something == "p")
            {
                check = 112;
            }

            if (check == Search)
            {
                hasMatch = true;

                int endIndex = num + 1;

                if (endIndex + i > text.Length)
                {
                    endIndex = text.Length - i;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += num;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
