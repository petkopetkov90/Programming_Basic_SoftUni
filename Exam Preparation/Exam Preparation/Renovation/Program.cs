using System;
using System.Data;
using System.Reflection;

namespace Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int percentNoPaint = int.Parse(Console.ReadLine());

            
            int area = height * wide * 4;
            double noPaint = area / 100.00 * percentNoPaint;
            double areaPaint = Math.Ceiling(area - noPaint);

            bool tired = false;
            

            while (!tired)
            {
                string litersOrTired = Console.ReadLine();
                if (litersOrTired == "Tired!")
                {
                    tired = true;
                    break;
                }
                int liters = int.Parse(litersOrTired);

                areaPaint -= liters;

                if (areaPaint <= 0)
                {
                    break;
                }
            }

            if (tired)
            {
                Console.WriteLine($"{areaPaint} quadratic m left.");
            }
            else
            {
                if (areaPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaPaint)} l paint left!");
                }
                else
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                }
            }
        }
    }
}