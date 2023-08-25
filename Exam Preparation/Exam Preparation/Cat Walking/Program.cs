using System;

namespace Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int walkMin = int.Parse(Console.ReadLine());
            int walkes = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            double caloriesBurn = walkes * walkMin * 5;

            if (caloriesBurn >= calories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurn}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurn}.");
            }
        }
    }
}