using System;

namespace Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (movieName == "John Wick")
            {
                if (ticketType == "Drink")
                {
                    ticketPrice = 12.00;
                }
                else if (ticketType == "Popcorn")
                {
                    ticketPrice = 15.00;
                }
                else if (ticketType == "Menu")
                {
                    ticketPrice = 19.00;
                }
            }
            else if (movieName == "Star Wars")
            {
                if (ticketType == "Drink")
                {
                    ticketPrice = 18.00;
                }
                else if (ticketType == "Popcorn")
                {
                    ticketPrice = 25.00;
                }
                else if (ticketType == "Menu")
                {
                    ticketPrice = 30.00;
                }
            }
            else if (movieName == "Jumanji")
            {
                if (ticketType == "Drink")
                {
                    ticketPrice = 9.00;
                }
                else if (ticketType == "Popcorn")
                {
                    ticketPrice = 11.00;
                }
                else if (ticketType == "Menu")
                {
                    ticketPrice = 14.00;
                }
            }

            double totalPrice = tickets * ticketPrice;

            if (movieName == "Star Wars" && tickets > 3)
            {
                totalPrice = totalPrice * 0.70;
            }
            else if (movieName == "Jumanji" && tickets == 2)
            {
                totalPrice = totalPrice * 0.85;
            }

            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
        }
    }
}