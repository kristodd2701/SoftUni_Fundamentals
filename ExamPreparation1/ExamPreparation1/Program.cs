﻿namespace ExamPreparation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command;
            int wins = 0;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }
                energy -= distance;
                wins++;

                if (wins % 3 == 0)
                {
                    energy += wins;
                }
            }
            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}
