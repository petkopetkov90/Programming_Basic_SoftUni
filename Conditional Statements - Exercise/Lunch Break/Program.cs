using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine(); // series name
            int episodTime = int.Parse(Console.ReadLine()); // episode time
            int lunchBreak = int.Parse(Console.ReadLine()); // lunch break time
                                                                                      // rest time in lunch break = 1/4 from lunch break
                                                                                       // lunch time from lunch break = 1/8 from lunch break
            double timeForWatch = lunchBreak - (lunchBreak / 8.00) - (lunchBreak / 4.00);      // time left for watching

            if (timeForWatch >= episodTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForWatch - episodTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodTime - timeForWatch)} more minutes.");
            }

        }
    }
}