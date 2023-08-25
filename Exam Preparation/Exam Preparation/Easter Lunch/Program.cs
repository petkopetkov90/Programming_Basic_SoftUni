using System;

namespace Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int eggsX12 = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            double easterBreadPrice = 3.20;
            double eggsX12Price = 4.35;
            double cookiesPrice = 5.40;
            double eggsPainPer1Egg = 0.15;

            double totalEsterBreakPrice = easterBread * easterBreadPrice;
            double totalEggsPrice = eggsX12 * eggsX12Price + (eggsX12 * 12 * eggsPainPer1Egg);
            double totalCookiesPrice = cookiesPrice * cookies;

            double totalAmount = totalEsterBreakPrice + totalEggsPrice + totalCookiesPrice;

            Console.WriteLine($"{totalAmount:f2}");

        }
    }
}