using System;
using System.Xml.Schema;

namespace Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drinkType = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinks = int.Parse(Console.ReadLine());

            double Price = 0.0;

            if (drinkType == "Espresso")
            {
                if (sugar == "Without")
                {
                    Price = 0.90;
                }
                else if(sugar == "Normal")
                {
                    Price = 1.00;
                }
                else
                {
                    Price = 1.20;
                }
            }
            else if (drinkType == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    Price = 1.00;
                }
                else if (sugar == "Normal")
                {
                    Price = 1.20;
                }
                else
                {
                    Price = 1.60;
                }

            }
            else if (drinkType == "Tea")
            {
                if (sugar == "Without")
                {
                    Price = 0.50;
                }
                else if (sugar == "Normal")
                {
                    Price = 0.60;
                }
                else
                {
                    Price = 0.70;
                }
            }

            double totalPrice = Price * drinks;

            if (sugar == "Without")
            {
                totalPrice = totalPrice * 0.65;
            }
            if(drinkType == "Espresso" && drinks >= 5)
            {
                totalPrice = totalPrice * 0.75;
            }
            if (totalPrice > 15)
            {
                totalPrice = totalPrice * 0.80;
            }
            Console.WriteLine($"You bought {drinks} cups of {drinkType} for {totalPrice:f2} lv.");
        }
    }
}