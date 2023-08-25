using System;

namespace Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int scenesTime = int.Parse(Console.ReadLine());

            double timeForScenes = time * 0.85;

            double timeNeed = scenes * scenesTime;

            if (timeForScenes >= timeNeed)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForScenes - timeNeed)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeNeed - timeForScenes)} minutes.");
            }
        }
    }
}