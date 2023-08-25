using System;
using System.Xml;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double moneyHave = 0;
            double moneyGift = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyHave += moneyGift -1;
                    moneyGift += 10;
                }
                else
                {
                    moneyHave += toyPrice;
                }
            }
            if (moneyHave >= washingMachine)
            {
                Console.WriteLine($"Yes! {moneyHave - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - moneyHave:f2}");
            }

        }
    }
}