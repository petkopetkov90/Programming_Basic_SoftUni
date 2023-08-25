using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWide = int.Parse(Console.ReadLine());
            int cakeLong = int.Parse(Console.ReadLine());

            int cakePieces = cakeWide * cakeLong;
            int piecesGet = 0;

            while (piecesGet < cakePieces)
            {
                string piecesOrStop = Console.ReadLine().ToLower();

                if (piecesOrStop == "stop")
                {
                    break;
                }

                int pieces = int.Parse(piecesOrStop);

                piecesGet += pieces;
            }

            if (piecesGet >= cakePieces)
            {
                Console.WriteLine($"No more cake left! You need {piecesGet - cakePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakePieces - piecesGet} pieces are left.");
            }

        }
    }
}