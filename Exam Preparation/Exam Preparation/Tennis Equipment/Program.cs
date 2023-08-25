using System;

namespace Tennis_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRackets = int.Parse(Console.ReadLine());
            int sneakers = int.Parse(Console.ReadLine());

            double sneakersPrice = tennisRacketPrice / 6;

            double cost = sneakers * sneakersPrice + tennisRackets * tennisRacketPrice;
            double totalCost = cost + cost * 0.20;
            double selfPaidCost = totalCost / 8;
            double sponsorCost = totalCost - selfPaidCost;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(selfPaidCost)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorCost)}");

        }
    }
}