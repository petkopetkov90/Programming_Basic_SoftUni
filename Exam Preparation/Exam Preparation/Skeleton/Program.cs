using System;

namespace Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int secondPer100M = int.Parse(Console.ReadLine());

            int totalSecondsNeed = minutes * 60 + seconds;
            double saveTimeSecond = distance / 120 * 2.5;
            double competitorTime = distance / 100 * secondPer100M - saveTimeSecond;
            
            if (competitorTime <= totalSecondsNeed)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {competitorTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {competitorTime - totalSecondsNeed:f3} second slower.");
            }

        }
    }
}