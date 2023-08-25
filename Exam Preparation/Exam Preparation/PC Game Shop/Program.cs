using System;

namespace PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesSold = int.Parse(Console.ReadLine());

            double hearthstone = 0;
            double fornite = 0;
            double overwatch = 0;
            double others = 0;

            for (int i = 0; i < gamesSold; i++)
            {
                string gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "Hearthstone": hearthstone++; break;
                    case "Fornite": fornite++; break;
                    case "Overwatch": overwatch++; break;
                    default: others++; break;
                }
            }

            double hearthstonePercent = hearthstone / gamesSold * 100;
            double fornitePercent = fornite / gamesSold * 100;
            double overwatchPercent = overwatch / gamesSold * 100;
            double othersPercent = others / gamesSold * 100;

            Console.WriteLine($"Hearthstone - {hearthstonePercent:f2}%");
            Console.WriteLine($"Fornite - {fornitePercent:f2}%");
            Console.WriteLine($"Overwatch - {overwatchPercent:f2}%");
            Console.WriteLine($"Others - {othersPercent:f2}%");
        }
    }
}