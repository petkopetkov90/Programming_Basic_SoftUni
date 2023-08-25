using System;
using System.Security.Principal;

namespace Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            int wins = 0;
            int draws = 0;
            int loses = 0;
            int points = 0;

            for (int i = 0; i < games; i++)
            {
                string results = Console.ReadLine();

                if (results == "W")
                {
                    wins++;
                    points += 3;
                }
                else if (results == "D")
                {
                    draws++;
                    points += 1;
                }
                else if (results == "L")
                {
                    loses++;
                }
            }

            double winrate = wins * 100.00 / games;

            if (games == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{name} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {wins}");
                Console.WriteLine($"## D: {draws}");
                Console.WriteLine($"## L: {loses}");
                Console.WriteLine($"Win rate: {winrate:f2}%");
            }
        }
    }
}