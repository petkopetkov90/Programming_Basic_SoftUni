using System;

namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            double totalPointsFromTour = 0;
            double tournamentsWins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string finish = Console.ReadLine().ToLower();

                if (finish == "w")
                {
                    totalPointsFromTour += 2000;
                    tournamentsWins++;
                }
                if (finish == "f")
                {
                    totalPointsFromTour += 1200;
                }
                if (finish == "sf")
                {
                    totalPointsFromTour += 720;
                }
            }

            double totalPoints = points + totalPointsFromTour;
            double pointsPerTour = totalPointsFromTour / tournaments;
            double winsPercent = tournamentsWins / tournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(pointsPerTour)}");
            Console.WriteLine($"{winsPercent:f2}%");

        }
    }
}