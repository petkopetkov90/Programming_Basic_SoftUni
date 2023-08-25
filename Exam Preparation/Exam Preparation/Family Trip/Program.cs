using System;

namespace Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int extraCostPercent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                pricePerNight = pricePerNight * 0.95;
            }

            double extraCost = budget / 100 * extraCostPercent;
            double nightsCost = nights * pricePerNight;
            double total = extraCost + nightsCost;

            if (total > budget)
            {
                Console.WriteLine($"{total - budget:f2} leva needed.");
            }
            else
            {
                Console.WriteLine($"Ivanovi will be left with {budget - total:f2} leva after vacation.");

            }
        }
    }
}