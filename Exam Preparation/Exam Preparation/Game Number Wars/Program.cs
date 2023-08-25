using System;

namespace Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();

            bool endOfGame = false;

            bool numberWars = false;

            string winner = string.Empty;

            int player1Points = 0;
            int player2Points = 0;

            int winnerPoints = 0;

            while (!endOfGame)
            {
                string card1 = Console.ReadLine();
                string card2 = Console.ReadLine();
                
                if (card1 == "End of game")
                {
                    endOfGame = true;
                    break;
                }
                int cardPlayer1 = int.Parse(card1);
                int cardPlayer2 = int.Parse(card2);

                if (cardPlayer1 == cardPlayer2)
                {
                    cardPlayer1 = int.Parse(Console.ReadLine());
                    cardPlayer2 = int.Parse(Console.ReadLine());

                    numberWars = true;

                    if (cardPlayer1 > cardPlayer2)
                    {
                        winner = player1;
                        winnerPoints = player1Points;
                    }
                    else
                    {
                        winner = player2;
                        winnerPoints = player2Points;
                    }

                    break;
                }

                else if (cardPlayer1 > cardPlayer2)
                {
                    player1Points += (cardPlayer1 - cardPlayer2);
                }
                else if (cardPlayer1 < cardPlayer2)
                {
                    player2Points += (cardPlayer2 - cardPlayer1);
                }
            }
            if (endOfGame)
            {
                Console.WriteLine($"{player1} has {player1Points} points");
                Console.WriteLine($"{player2} has {player2Points} points");
            }
            if (numberWars)
            {
                Console.WriteLine("Number wars!");
                Console.WriteLine($"{winner} is winner with {winnerPoints} points");
            }
        }
    }
}