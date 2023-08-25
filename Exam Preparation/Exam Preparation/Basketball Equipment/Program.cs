using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());

            double sneakersPrice = taxPerYear * 0.60;
            double outfitPrice = sneakersPrice * 0.80;
            double ballPrice = outfitPrice / 4;
            double accesoriesPrice = ballPrice / 5;

            double totalExpenses = sneakersPrice + outfitPrice + ballPrice + accesoriesPrice + taxPerYear;

            Console.WriteLine($"{totalExpenses:f2}");
        }

    }
}