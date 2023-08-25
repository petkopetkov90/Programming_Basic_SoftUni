using System;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine()); // world record in seconds
            double distance = double.Parse(Console.ReadLine()); // distance in meters
            double swimTimeForMeter = double.Parse(Console.ReadLine()); // time in sec to swin 1meter
            double resistanceTime = Math.Floor(distance / 15) * 12.5; // time lost in water resistance
            double timeNeed = (swimTimeForMeter * distance) + resistanceTime;  // total time in sec to finish

            if (timeNeed < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeNeed:f2} seconds.");
            }
            else
            {

                Console.WriteLine($"No, he failed! He was {(timeNeed - worldRecord):f2} seconds slower.");
            }

        }
    }
}