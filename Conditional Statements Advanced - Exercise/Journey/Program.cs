using System;
using System.Text;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string place = string.Empty;
            string type = string.Empty;

            double price = 0;

            if (budget <= 100)
            {
                place = "Bulgaria";

                if (season == "summer")
                {
                    type = "Camp";
                    price = budget * 0.30;
                }
                else
                {
                    type = "Hotel";
                    price = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";

                if (season == "summer")
                {
                    type = "Camp";
                    price = budget * 0.40;
                }
                else
                {
                    type = "Hotel"; 
                    price = budget * 0.80;
                }
            }
            else
            {
                place = "Europe";
                type = "Hotel";
                price = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}