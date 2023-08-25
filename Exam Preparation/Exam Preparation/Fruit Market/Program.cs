using System;

namespace Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaKG = double.Parse(Console.ReadLine());
            double orangeKG = double.Parse(Console.ReadLine());
            double raspberryKG = double.Parse(Console.ReadLine());
            double strawberryKG = double.Parse(Console.ReadLine());

            double raspberryPrice = strawberryPrice / 2.0;
            double orangePrice = raspberryPrice * 0.60;
            double bananaPrice = raspberryPrice * 0.20;

            double totalPrice = strawberryPrice * strawberryKG + bananaKG * bananaPrice + orangeKG * orangePrice + raspberryKG * raspberryPrice;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}