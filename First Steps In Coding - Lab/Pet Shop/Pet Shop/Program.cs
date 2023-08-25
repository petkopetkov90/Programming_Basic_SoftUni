using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hranaKuche = int.Parse(Console.ReadLine());
            int hranaKotka = int.Parse(Console.ReadLine());
            double cenaKuche = hranaKuche * 2.50;
            double cenaKotka = hranaKotka * 4.00;
            double total = cenaKuche + cenaKotka;
            Console.WriteLine(total + " lv.");
        }
    }
}