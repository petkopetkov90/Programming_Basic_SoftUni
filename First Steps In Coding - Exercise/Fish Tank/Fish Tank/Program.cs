using System;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentUsed = double.Parse(Console.ReadLine());
            double totalM3sm = length * width * height;
            double totalM3dm = totalM3sm / 1000;
            double usedM3dm = totalM3dm * (percentUsed / 100);
            double waterliters = (totalM3dm - usedM3dm) * 1;
            Console.WriteLine(waterliters);

        }
    }
}