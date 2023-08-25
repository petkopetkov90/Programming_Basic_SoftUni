using System;

namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            int totalMin = totalTime / 60;
            int totalSec = totalTime % 60;
            
            if (totalSec < 10)
            {
                Console.WriteLine($"{totalMin}:0{totalSec}");
            }
            else
            {
                Console.WriteLine(totalMin + ":" + totalSec);
            }

        }
    }
}