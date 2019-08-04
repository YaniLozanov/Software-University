﻿using System;
using System.Text;
using System.Text.RegularExpressions;
public class Use_Your_Chains_Buddy
{
    public static void Main()  
    {

        // Problem:
        // This problem is from the JavaScript Basics Exam (9 January 2015).
        // You may check your solution here.
        // You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut.
        // You need to get there by car.
        // But there is so much snow that you need to use car chains.
        // In order to put them on the wheels correctly, you need to read the manual.
        // But it is encrypted…
        // As input you will receive an HTML document as a single string.
        // You need to get the text from all the<p> tags and replace all characters which are not small letters and numbers with a space " ".
        // After that you must decrypt the text – all letters from a to m are converted to letters from n to z(a  n; b  o; … m  z). 
        // The letters from n to z are converted to letters from a to m(n  a; o  b; … z  m). 
        // All multiple spaces should then be replaced by only one space.
        // For example, if we have "<div>Santa</div><p>znahny # grkg ()&^^^&12</p>" we extract "znahny # grkg ()&^^^&12".
        // Every character that is not a small letter or a number is replaced with a space("znahny grkg       12").
        // We convert each small letter as described above("znahny grkg 12"  "manual text 12") and replace all multiple spaces with only one space("manual text 12").
        // Finally, we concatenate the decrypted text from all<p> </ p > tags(in this case, it's only one).
        // And there you go – you have the manual ready to read!



string HTMLtext = Console.ReadLine();

        string pattern = @"<p>(.+?)<\/p>";
        MatchCollection matches = Regex.Matches(HTMLtext, pattern);

        string currentMatch = string.Empty;

        foreach (Match match in matches)
        {
            currentMatch += match.Groups[1].Value;
        }

        currentMatch = Regex.Replace(currentMatch, @"[^a-z0-9]", " ");
        currentMatch = Regex.Replace(currentMatch, @"\s+", " ");

        StringBuilder decryptedText = new StringBuilder();

        foreach (char @char in currentMatch)
        {
            char currentChar = @char;

            if (@char >= 'a' && @char <= 'm')
            {
                currentChar = (char)(@char + 13);
            }

            else if (@char >= 'n' && @char <= 'z')
            {
                currentChar = (char)(@char - 13);
            }

            decryptedText.Append(currentChar);
        }

        Console.WriteLine(decryptedText.ToString());
    }
}