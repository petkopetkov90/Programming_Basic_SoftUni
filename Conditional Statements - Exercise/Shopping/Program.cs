using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine()); // money have
            int videoN = int.Parse(Console.ReadLine()); // vedocard needs to buy
            int processorsM = int.Parse(Console.ReadLine()); // processors need to buy
            int ramMemoryP = int.Parse(Console.ReadLine()); // ram memory need to buy
            double videoPrice = videoN * 250.00;   // video card total cost 
            double processorsPrice = processorsM * (videoPrice * 0.35);  //processors total cost
            double memoryPrice = ramMemoryP * (videoPrice * 0.10);  // memory total cost
            double totalPrice = videoPrice + memoryPrice + processorsPrice;  // total cost for all 

            if (videoN > processorsM)
            {
                totalPrice -= totalPrice * 0.15;   // totalPrice = totalPrice - (totalPrice * 0.15);
            }

            if (moneyHave >= totalPrice)
            {
                Console.WriteLine($"You have {moneyHave - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - moneyHave:f2} leva more!");
            }
        }
    }
}