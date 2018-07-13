using System;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem:
            // Gosho and Pesho are neighbours, but they don’t like each other very much.
            // They don’t like violence as well, so they decided they need a save environment where they can fight each other. 
            // They hired you to write a program, which calculates who would win the fight. 
            // Gosho and Pesho have their own signature attacks – Gosho attacks with “Thunderous fist” on every even turn of the game and Pesho attacks with “Roundhouse kick” on every odd turn.
            // You will receive how much damage these attacks do from the console.
            // Both players start with 100 Health points.
            // On every third turn Pesho and Gosho restore 10 Health Points.
            // Health points are restored after the attack is made.
            // When one of the player’s health is below or equal to zero you should stop any other further operations and print who the winner is, how much health points he has and in which turn he won. 
            // Since Mike Tyson is the judge of the match, the winning round is always printed with “th” in the end.


            int peshosDmg = int.Parse(Console.ReadLine());
            int goshosDmg = int.Parse(Console.ReadLine());

            int goshosHealth = 100;
            int peshosHealth = 100;
            int rounds = 0;
            int indexForHealthRestore = 0;

            while (true)
            {
                rounds++;

                if (rounds % 2 != 0)
                {
                    goshosHealth -= peshosDmg;

                    if (goshosHealth <= 0 || peshosHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else if (rounds % 2 == 0)
                {
                    peshosHealth -= goshosDmg;

                    if (goshosHealth <= 0 || peshosHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }

                if (rounds % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
            }

            if (peshosHealth > 0)
            {
                Console.WriteLine($"Pesho won in {rounds}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {rounds}th round.");

            }
        }
    }
}
