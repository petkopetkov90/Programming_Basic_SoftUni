using System;

namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            bool retire = false;

            int pointsNeed = 301;
            int pointsHit = 0;
            int shots = 0;
            int badShots = 0;

            while (!retire)
            {
                string type = Console.ReadLine();

                if (type == "Retire")
                {
                    retire = true;
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                shots++;

                if (type == "Double")
                {
                    points = points * 2;
                }
                else if (type == "Triple")
                {
                    points = points * 3;
                }

                pointsHit += points;

                if (pointsHit > pointsNeed)
                {
                    pointsHit = pointsHit - points;
                    badShots++;
                    shots--;
                }
                if (pointsHit == pointsNeed)
                {
                    break;
                }
            }
            if (retire)
            {
                Console.WriteLine($"{playerName} retired after {badShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} won the leg with {shots} shots.");
            }

        }
    }
}