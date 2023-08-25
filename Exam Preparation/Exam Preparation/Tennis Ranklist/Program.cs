using System;

namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tours = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int pointsWin = 0;
            int toursWin = 0;

            for (int i = 0; i < tours; i++)
            {
                string winDrawLose = Console.ReadLine();

                switch (winDrawLose)
                {
                    case "W": pointsWin += 2000;
                        toursWin++;
                        break;
                    case "F":
                        pointsWin += 1200;
                        break;
                    case "SF":
                        pointsWin += 720;
                        break;
                }
            }

            double totalPoints = pointsWin + startPoints;
            double pointsPerTour = pointsWin / tours;
            double winPercent = toursWin * 100.00 / tours;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(pointsPerTour)}");
            Console.WriteLine($"{winPercent:f2}%");
        }
    }
}