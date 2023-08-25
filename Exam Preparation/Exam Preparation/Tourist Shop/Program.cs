using System;

namespace Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            bool stop = false;

            double totalCost = 0;
            int productsCount = 0;

            while (!stop)
            {
                string product = Console.ReadLine();

                if (product == "Stop")
                {
                    stop = true;
                    break;
                }

                productsCount++;
                double productPrice = double.Parse(Console.ReadLine());

                if (productsCount % 3 == 0)
                {
                    productPrice = productPrice / 2.0;
                }
                totalCost += productPrice;

                if (totalCost > budget)
                {
                    break;
                }
            }
            if (stop)
            {
                Console.WriteLine($"You bought {productsCount} products for {totalCost:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {totalCost - budget:f2} leva!");
            }
        }
    }
}