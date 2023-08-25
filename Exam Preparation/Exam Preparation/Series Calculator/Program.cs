using System;

namespace Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());
            double seriesTime = double.Parse(Console.ReadLine());

            double totalTime = seasons * series * (seriesTime * 1.20) + (seasons * 10);

            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(totalTime)} minutes.");

        }
    }
}