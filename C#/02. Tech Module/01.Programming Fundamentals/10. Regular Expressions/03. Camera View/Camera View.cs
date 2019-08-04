using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03._Camera_View
{
    class CameraView
    {
        // Problem:
        // You are an amateur photographer and you want to calculate what will be seen in your pictures.
        // On the first line, you will receive an array of integers with exactly two elements:
        // First element – m will be the elements, which you have to skip.
        // The second element – n will be the elements, which you have to take.
        // On the next line, you will receive a string, in which every camera will be marked with "|<".
        // Skip the next m elements immediately after the camera and take the next n elements.
        // If you encounter new camera in the view  stop the current camera and start new view with the newly found.

        static void Main(string[] args)
        {
            int[] operators = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // We recive num of skip and num of take
            string text = Console.ReadLine();

            List<string> printList = new List<string>();

            // "\\|<(\\w{" + skip + "})(\\w{0," + take + "})";
            string pattern = "\\|<(\\w{"+operators[0]+"})(\\w{0,"+ operators[1] +"})";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                printList.Add((item.Groups[2].ToString()));
            }

            Console.WriteLine(string.Join(", ", printList));
        }
    }
}
