using System;

namespace Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesWon = 0;
            int gamesLost = 0;
            int gamesDraw = 0;

            for (int i = 0; i < 3; i++)
            {
                string result = Console.ReadLine();

                if (result[0] > result[2])
                {
                    gamesWon++;
                }
                else if (result[0] == result[2])
                {
                    gamesDraw++;
                }
                else
                {
                    gamesLost++;
                }
            }

            Console.WriteLine($"Team won {gamesWon} games.");
            Console.WriteLine($"Team lost {gamesLost} games.");
            Console.WriteLine($"Drawn games: {gamesDraw}");
        }
    }
}