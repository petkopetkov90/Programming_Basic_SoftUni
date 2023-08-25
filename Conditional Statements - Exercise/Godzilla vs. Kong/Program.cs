using System;
using System.ComponentModel;
using System.Data;

namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double invested = double.Parse(Console.ReadLine()); // amount invested
            int workers = int.Parse(Console.ReadLine());  // workers 
            double pricePerWorker = double.Parse(Console.ReadLine()); // price for clothes for each worker
            double decorPrice = invested * 0.10; //price for decor
            double clothesPrice = workers * pricePerWorker;  // total price for clothes

            if (workers >= 150)
            {
                double clothesPriceWithDiscount = clothesPrice - (clothesPrice * 0.10);  // total price for clothes with discount
                double totalExpenses = clothesPriceWithDiscount + decorPrice;  // total expenses for workers + decor

                if (invested < totalExpenses)
                {
                    double needMore = totalExpenses - invested; 
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine("Wingard needs " + "{0:F2}" + " leva more.", needMore);
                }
                else
                {
                    double moneyLeft = invested - totalExpenses;  // amount left after pay expenses
                    Console.WriteLine("Action!");
                    Console.WriteLine("Wingard starts filming with " + "{0:F2}" + " leva left.", moneyLeft);
                }
            }
            else
            {
                double totalExpenses = clothesPrice + decorPrice;  // total expenses for workers + decor

                if (invested < totalExpenses)
                {
                    double needMore = totalExpenses - invested;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine("Wingard needs " + "{0:F2}" + " leva more.", needMore);
                }
                else
                {
                    double moneyLeft = invested - totalExpenses;  // amount left after pay expenses
                    Console.WriteLine("Action!");
                    Console.WriteLine("Wingard starts filming with " + "{0:F2}" + " leva left.", moneyLeft);
                }
            }

        }
    }
}