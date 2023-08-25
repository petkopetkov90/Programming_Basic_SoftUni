using System;

namespace Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.00;

            if (city == "sofia")
            {
                switch (product)
                {
                    case "coffee": price = 0.50; break;
                    case "water": price = 0.80; break;
                    case "beer": price = 1.20; break;
                    case "sweets": price = 1.45; break;
                    case "peanuts": price = 1.60; break;
                }
            }
            else if (city == "plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = 0.40; break;
                    case "water": price = 0.70; break;
                    case "beer": price = 1.15; break;
                    case "sweets": price = 1.30; break;
                    case "peanuts": price = 1.50; break;
                }
            }
            else if (city == "varna")
            {
                switch (product)
                {
                    case "coffee": price = 0.45; break;
                    case "water": price = 0.70; break;
                    case "beer": price = 1.10; break;
                    case "sweets": price = 1.35; break;
                    case "peanuts": price = 1.55; break;
                }
            }
            Console.WriteLine(price * quantity);
        }
    }
}