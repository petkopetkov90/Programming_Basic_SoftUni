using System;

namespace Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double daysOff = int.Parse(Console.ReadLine());
            double foodKG = int.Parse(Console.ReadLine());
            double firstDeerfoodPerDayKF = double.Parse(Console.ReadLine());
            double secondDeerfoodPerDayKF = double.Parse(Console.ReadLine());
            double thirdDeerfoodPerDayKF = double.Parse(Console.ReadLine());

            double foodNeed = ((firstDeerfoodPerDayKF * daysOff)) + (secondDeerfoodPerDayKF * daysOff) + (thirdDeerfoodPerDayKF * daysOff);
          

            if (foodKG >= foodNeed)
            {
                Console.WriteLine($"{Math.Floor(foodKG - foodNeed)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeed - foodKG)} more kilos of food are needed.");
            }
        }
    }
}