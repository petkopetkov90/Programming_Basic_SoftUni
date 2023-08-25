using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            if (month == "may" ||  month == "october")
            {
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = 50 * 0.95;
                    apartmentPrice = 65;
                }
                else if (nights > 14) 
                {
                    studioPrice = 50 * 0.70;
                    apartmentPrice = 65 * 0.90;
                }
                else
                {
                    studioPrice = 50;
                    apartmentPrice = 65;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nights > 14)
                {
                    studioPrice = 75.20 * 0.80;
                    apartmentPrice = 68.70 * 0.90;
                }
                else
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                }
            }
            else
            {
                if ( nights > 14)
                {
                    studioPrice = 76;
                    apartmentPrice = 77 * 0.90;
                }
                else
                {
                    studioPrice = 76;
                    apartmentPrice = 77;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice * nights:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice * nights:f2} lv.");
        }
    }
}