using System;

namespace Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatPercent = int.Parse(Console.ReadLine());
            int proteinPercent = int.Parse(Console.ReadLine());
            int carboPercent = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());
            int waterPercent = int.Parse(Console.ReadLine());

            double fatGrams = (fatPercent / 100.00 * caloriesPerDay) / 9.00;
            double proteinGrams = (proteinPercent / 100.00 * caloriesPerDay) / 4.00;
            double carboGrams = (carboPercent / 100.00 * caloriesPerDay) / 4.00;

            double totalGrams = fatGrams + proteinGrams + carboGrams;
            double gramCalories = caloriesPerDay / totalGrams;
            double gramCaloriesNoWater = gramCalories - gramCalories / 100.00 * waterPercent;

            Console.WriteLine($"{gramCaloriesNoWater:f4}");
        }
    }
}