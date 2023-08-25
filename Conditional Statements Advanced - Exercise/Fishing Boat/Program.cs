using System;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            int fishermans = int.Parse(Console.ReadLine());

            double rentPrice = 0;

            if (season == "spring")
            {
                if (fishermans <= 6)
                {
                    rentPrice = 3000 * 0.90;
                }
                else if (fishermans <= 11)
                {
                    rentPrice = 3000 * 0.85;
                }
                else
                {
                    rentPrice = 3000 * 0.75;
                }
            }
            else if (season == "summer" || season == "autumn")
            {
                if (fishermans <= 6)
                {
                    rentPrice = 4200 * 0.90;
                }
                else if (fishermans <= 11)
                {
                    rentPrice = 4200 * 0.85;
                }
                else
                {
                    rentPrice = 4200 * 0.75;
                }
            }
            else
            {
                if (fishermans <= 6)
                {
                    rentPrice = 2600 * 0.90;
                }
                else if (fishermans <= 11)
                {
                    rentPrice = 2600 * 0.85;
                }
                else
                {
                    rentPrice = 2600 * 0.75;
                }
            }
            if (fishermans % 2 == 0 && season != "autumn")
            {
                rentPrice = rentPrice * 0.95;
            }
            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {budget - rentPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rentPrice - budget:f2} leva.");
            }

        }
    }
}