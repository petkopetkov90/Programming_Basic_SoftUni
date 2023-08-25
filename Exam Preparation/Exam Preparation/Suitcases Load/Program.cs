using System;

namespace Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double planePlace = double.Parse(Console.ReadLine());

            int loadsCounter = 0;
            double totalVolume = 0;

            bool end = false;

            while (true)
            {
                string loadVolume = (Console.ReadLine());
                double newLoadVolume = 0;

                if (loadVolume == "End")
                {
                    end = true;
                    break;
                }

                newLoadVolume = double.Parse(loadVolume);

                loadsCounter++;

                if (loadsCounter % 3 == 0)
                {
                    newLoadVolume *= 1.10;
                }

                totalVolume += newLoadVolume;

                if (planePlace < totalVolume)
                {
                    loadsCounter--;
                    break;
                }

            }

            if (end)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine($"No more space!");
            }

            Console.WriteLine($"Statistic: {loadsCounter} suitcases loaded.");
        }
    }
}