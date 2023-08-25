using System;

namespace Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = days - 1;
            double pricePerNight = 0;

            if (type == "room for one person")
            {
                pricePerNight = 18.00;
            }
            else if (type == "apartment")
            {
                pricePerNight = 25.00;

                if (days < 10)
                {
                    pricePerNight = pricePerNight * 0.70;
                }
                else if (days <= 15)
                {
                    pricePerNight = pricePerNight * 0.65;
                }
                else
                {
                    pricePerNight = pricePerNight * 0.50;
                }
            }
            else if (type == "president apartment")
            {
                pricePerNight = 35.00;

                if (days < 10)
                {
                    pricePerNight = pricePerNight * 0.90;
                }
                else if (days <= 15)
                {
                    pricePerNight = pricePerNight * 0.85;
                }
                else
                {
                    pricePerNight = pricePerNight * 0.80;
                }
            }

            double totalPrice = nights * pricePerNight;

            if (rating == "positive")
            {
                totalPrice = totalPrice * 1.25;
            }
            else
            {
                totalPrice = totalPrice * 0.90;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}