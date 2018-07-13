using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);

            string health = new string('|', currentHealth);
            string missingHealth = new string('.', maximumHealth - currentHealth);

            Console.WriteLine($"Health: |{health}{missingHealth}|");

            string energy = new string('|', currentEnergy);
            string missingEnergy = new string('.', maximumEnergy - currentEnergy);

            Console.WriteLine($"Energy: |{energy}{missingEnergy}|");



        }
    }
}
