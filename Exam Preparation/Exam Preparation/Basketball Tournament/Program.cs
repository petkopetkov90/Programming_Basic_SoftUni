using System;

namespace Basketball_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();
            double totalGames = 0.0;
            double totalWins = 0.0;
            double totalLoses = 0.0;

            while (tournamentName != "End of tournaments")
            {
                int games = int.Parse(Console.ReadLine());
                int gamesCounter = 0;

                for (int i = 0; i < games; i++)
                {
                    int pointsHome = int.Parse(Console.ReadLine());
                    int pointsAway = int.Parse(Console.ReadLine());
                    gamesCounter++;
                    totalGames++;
                    if (pointsHome > pointsAway)
                    {
                        totalWins++;
                        Console.WriteLine($"Game {gamesCounter} of tournament {tournamentName}: win with {pointsHome - pointsAway} points.");
                    }
                    else
                    {
                        totalLoses++;
                        Console.WriteLine($"Game {gamesCounter} of tournament {tournamentName}: lost with {pointsAway - pointsHome} points.");
                    }
                }

                tournamentName = Console.ReadLine();
            }

            double winsPercent = totalWins / totalGames * 100;
            double losesPercent = totalLoses / totalGames * 100;

            Console.WriteLine($"{winsPercent:f2}% matches win");
            Console.WriteLine($"{losesPercent:f2}% matches lost");
        }
    }
}