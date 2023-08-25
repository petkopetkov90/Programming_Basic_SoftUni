using System;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double pensPacks = double.Parse(Console.ReadLine());
            double markerPacks = double.Parse(Console.ReadLine());
            double cleaningLiters = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double pensPrice = pensPacks * 5.80;
            double markerPrice = markerPacks * 7.20;
            double cleaningPrice = cleaningLiters * 1.20;
            double totalPrice = pensPrice + markerPrice + cleaningPrice;
            double totalDiscount = (discount / 100) * totalPrice;
            Console.WriteLine(totalPrice - totalDiscount);
        }
    }
}