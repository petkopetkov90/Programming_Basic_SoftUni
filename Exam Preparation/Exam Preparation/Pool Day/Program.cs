using System;

namespace Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workers = int.Parse(Console.ReadLine());
            double enterFee = double.Parse(Console.ReadLine());
            double sunbedFee = double.Parse(Console.ReadLine());
            double umbrellaFee = double.Parse(Console.ReadLine());  // 1 for 2 workers

            double sunbedPrice = Math.Ceiling(workers * 0.75) * sunbedFee;
            double umbrellaPrice = Math.Ceiling(workers / 2.00) * umbrellaFee;
            double enterPrice = workers * enterFee;

            double total = sunbedPrice + umbrellaPrice + enterPrice;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}