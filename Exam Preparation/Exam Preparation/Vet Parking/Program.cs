using System;

namespace Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalCost = 0;
            double dayOne = 0;

            for (int day = 1; day <= days; day++)
            {
                double totalCostPerDay = 0;

                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        totalCostPerDay += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        totalCostPerDay += 1.25;
                    }
                    else
                    {
                        totalCostPerDay += 1.00;
                    }
               
                }

                Console.WriteLine($"Day: {day} - {totalCostPerDay:f2} leva");
                totalCost += totalCostPerDay;
            }

            Console.WriteLine($"Total: {totalCost:f2} leva");

        }
    }
}