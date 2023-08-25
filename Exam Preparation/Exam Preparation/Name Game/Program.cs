using System;

namespace Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int winnerPoints = int.MinValue;
            string winnerName = string.Empty;

            while (name != "Stop")
            {
                int points = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num == name[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }

                if (points >= winnerPoints)
                {
                    winnerPoints = points;
                    winnerName = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winnerName} with {winnerPoints} points!");
        }
    }
}