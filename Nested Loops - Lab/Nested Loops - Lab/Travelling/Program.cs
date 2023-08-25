using System;

namespace Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double cost = double.Parse(Console.ReadLine());

                double moneySaved = 0;

                while (cost > moneySaved)
                {
                    double moneySave = double.Parse(Console.ReadLine());
                    moneySaved += moneySave;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}