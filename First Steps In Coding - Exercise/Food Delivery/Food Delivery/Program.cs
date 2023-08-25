using System;
using System.Xml.Schema;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chikenMeal = double.Parse(Console.ReadLine());
            double fishMeal = double.Parse(Console.ReadLine());
            double veganMeal = double.Parse(Console.ReadLine());
            double chikenPrice = chikenMeal * 10.35;
            double fishPrice = fishMeal * 12.40;
            double veganPrice = veganMeal * 8.15;
            double PriceMeals = chikenPrice + fishPrice + veganPrice;
            double desertPrice = PriceMeals * 0.20;
            double deliveryPrice = 2.50;
            double totalPrice = PriceMeals + desertPrice + deliveryPrice;
            Console.WriteLine(totalPrice);


        }
    }
}