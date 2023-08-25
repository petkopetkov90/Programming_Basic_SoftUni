using System;

namespace Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());

            double moneyWin = 0;
            int totalGamesWon = 0;
            int totalGamesLost = 0;

            for (int i = 0; i < tournamentDays; i++)
            {
                string gametype = Console.ReadLine();

                double monetWinForTheDay = 0;
                int gameWin = 0;
                int gameLost = 0;

                while (gametype != "Finish")
                {
                    string resultWinOrLose = Console.ReadLine();

                    if (resultWinOrLose == "win")
                    {
                        monetWinForTheDay += 20;
                        gameWin++;
                    }
                    else
                    {
                        gameLost++;
                    }
                    
                    gametype = Console.ReadLine();
                }

                if (gameWin > gameLost)
                {
                    monetWinForTheDay = monetWinForTheDay * 1.10;
                }

                moneyWin += monetWinForTheDay;

                totalGamesWon += gameWin;
                totalGamesLost += gameLost;
            }

            if (totalGamesWon > totalGamesLost)
            {
                moneyWin = moneyWin * 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyWin:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyWin:f2}");
            }
        }
    }
}