using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());
            double sneakers = taxPerYear - (taxPerYear * 0.40);
            double outfit = sneakers - (sneakers * 0.20);
            double ball = outfit / 4;
            double accesories = ball / 5;
            double totalPrice = sneakers + outfit + ball + accesories + taxPerYear;
            Console.WriteLine(totalPrice);



        }
    }
}