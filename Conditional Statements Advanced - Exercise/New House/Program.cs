using System;
using System.Reflection;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowersType == "Roses")
            {
                if (flowers > 80)
                {
                    price = 5 * 0.90;
                }
                else
                {
                    price = 5;
                }
            }
            else if (flowersType == "Dahlias")
            {
                if (flowers > 90)
                {
                    price = 3.80 * 0.85;
                }
                else
                {
                    price = 3.80;
                }
            }
            else if (flowersType == "Tulips")
            {
                if (flowers > 80)
                {
                    price = 2.80 * 0.85;
                }
                else
                {
                    price = 2.80;
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (flowers < 120)
                {
                    price = 3 * 1.15;
                }
                else
                {
                    price = 3;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (flowers < 80)
                {
                    price = 2.50 * 1.20;
                }
                else
                {
                    price = 2.50;
                }
            }
            if (budget >= (price * flowers))
            {
                Console.WriteLine($"Hey, you have a great garden with {flowers} {flowersType} and {budget - (price * flowers):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price * flowers - budget:f2} leva more.");
            }

        }
    }
}