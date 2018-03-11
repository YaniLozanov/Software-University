using System;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
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

               

                if (rounds % 3 == 0 )
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
