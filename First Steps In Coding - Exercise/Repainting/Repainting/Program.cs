using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());   
            double paintThinner = double.Parse(Console.ReadLine());
            double hoursNeeded = double.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint + (paint * 0.10)) * 14.50;
            double paintThinnerPrice = paintThinner * 5.00;
            double bags = 0.40;
            double totalMaterialsPrice = nylonPrice + paintPrice + paintThinnerPrice + bags;
            double pricePerHour = totalMaterialsPrice * 0.30;
            double totalPrice = totalMaterialsPrice + (pricePerHour * hoursNeeded);
            Console.WriteLine(totalPrice);


        }
    }
}