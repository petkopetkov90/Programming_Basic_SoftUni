using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine().ToLower();
            string rating = Console.ReadLine().ToLower();

            int nights = days - 1;
            double roomForOne = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;

            if (days < 10)
            {
                apartment = 25.00 * 0.70;
                presidentApartment = 35.00 * 0.90;
            }
            else if (days <= 15)
            {
                apartment = 25.00 * 0.65;
                presidentApartment = 35.00 * 0.85;
            }
            else
            {
                apartment = 25.00 * 0.50;
                presidentApartment = 35.00 * 0.80;
            }

            double totalPrice = 0;

            if (room == "room for one person")
            {
                if (rating == "positive")
                {
                    totalPrice = (nights * roomForOne) * 1.25;
                }
                else
                {
                    totalPrice = (nights * roomForOne) * 0.90;
                }
            }
            else if (room == "apartment")
            {
                if (rating == "positive")
                {
                    totalPrice = (nights * apartment) * 1.25;
                }
                else
                {
                    totalPrice = (nights * apartment) * 0.90;
                }
            }
            else
            {
                if (rating == "positive")
                {
                    totalPrice = (nights * presidentApartment) * 1.25;
                }
                else
                {
                    totalPrice = (nights * presidentApartment) * 0.90;
                }
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}