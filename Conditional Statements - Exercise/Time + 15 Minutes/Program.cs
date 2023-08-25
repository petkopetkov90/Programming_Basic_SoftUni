using System;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int totalHours = (hour + (min + 15) / 60);
            int totalMins = (min + 15) % 60;

            if (totalHours < 24)
            {
                if (totalMins < 10)
                {
                    Console.WriteLine(totalHours + ":0" + totalMins);
                }
                else
                {
                    Console.WriteLine(totalHours + ":" + totalMins);
                }

            }
            else if (totalHours >= 24)
            {
                totalHours = totalHours - 24;

                if (totalMins < 10)
                {
                    Console.WriteLine(totalHours + ":0" + totalMins);
                }
                else
                {
                    Console.WriteLine(totalHours + ":" + totalMins);
                }

            }
        }
    }
}