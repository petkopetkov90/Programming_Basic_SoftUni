using System;

namespace Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelLiters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double fuelPrice = 2.10;
            double tourGuide = 100;

            double totalCost = fuelLiters * fuelPrice + tourGuide;

            if (day == "Saturday")
            {
                totalCost *= 0.90;
            }
            else if (day == "Sunday")
            {
                totalCost *= 0.80;
            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalCost:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalCost - budget:f2} lv.");
            }
        }
    }
}