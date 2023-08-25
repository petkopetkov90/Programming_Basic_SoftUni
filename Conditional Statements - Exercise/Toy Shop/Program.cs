using System;
using System.Xml.Schema;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());  //price for trip
            int puzzles = int.Parse(Console.ReadLine());  // total puzzles sold
            int dols = int.Parse(Console.ReadLine());   // total dols sold
            int bears = int.Parse(Console.ReadLine());  // total bears sold
            int minions = int.Parse(Console.ReadLine());  // total minions sold
            int trucks = int.Parse(Console.ReadLine());  // total trucks sold

            int totalToys = puzzles + dols + bears + trucks + minions; // total toys order

            double puzzleCost = puzzles * 2.60; // amount from puzzles
            double dolsCost = dols * 3.00; // amount from dols
            double bearsCost = bears * 4.10; // amount from bears
            double minionsCost = minions * 8.20; // amount from minions
            double trucksCost = trucks * 2.00; //amount from trucks

            double totalEarned = puzzleCost + dolsCost + bearsCost + minionsCost + trucksCost;  // total profit

            if (totalToys >= 50)
            {
                double totalDiscount = totalEarned * 0.25;  //  discount
                double totalEarnedAfterDiscount = totalEarned - totalDiscount; // amount after discount
                double rentPrice = totalEarnedAfterDiscount * 0.10; // rent price
                double pureProfit = totalEarnedAfterDiscount - rentPrice;   // amount after rent
                
                if (pureProfit >= tripPrice)
                {
                    double moneyLeft = pureProfit - tripPrice;  // money left after trip
                    Console.WriteLine("Yes! " + "{0:F2}" + " lv left.", moneyLeft);
                }
                else
                {
                    double moneyNeed = tripPrice - pureProfit; // money still need
                    Console.WriteLine("Not enough money! " + "{0:F2}" + " lv needed.", moneyNeed);
                }
            }
            else
            {
                
                double rentPrice = totalEarned * 0.10;    // rent price
                double pureProfit = totalEarned - rentPrice;   // amount after rent

                if (pureProfit >= tripPrice)
                {
                    double moneyLeft = pureProfit - tripPrice;  // money left after trip
                    Console.WriteLine("Yes! " + "{0:F2}" + " lv left.", moneyLeft);
                }
                else
                {
                    double moneyNeed = tripPrice - pureProfit; // money still need
                    Console.WriteLine("Not enough money! " + "{0:F2}" + " lv needed.", moneyNeed);
                }
            }

        }
    }
}