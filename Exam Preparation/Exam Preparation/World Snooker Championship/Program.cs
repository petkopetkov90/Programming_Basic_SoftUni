using System;
using System.Runtime.InteropServices;

namespace World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string round = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            string pictureYorNo = Console.ReadLine();

            double ticketPrice = 0;
            double extraTicketCost = 0;

            if (round == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = 55.50;
                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = 105.20;
                }
                else if (ticketType == "VIP")
                {
                    ticketPrice = 118.90;
                }
            }
            else if (round == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = 75.88;
                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = 125.22;
                }
                else if (ticketType == "VIP")
                {
                    ticketPrice = 300.40;
                }
            }
            else if (round == "Final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = 110.10;
                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = 160.66;
                }
                else if (ticketType == "VIP")
                {
                    ticketPrice = 400.00;
                }
            }

            double ticketsCost = ticketPrice * tickets;

            if (pictureYorNo == "Y")
            {
                extraTicketCost = 40;
            }

            if (ticketsCost > 4000)
            {
                extraTicketCost = 0;
                ticketsCost = ticketsCost * 0.75;
            }
            else if (ticketsCost > 2500)
            {
                ticketsCost = ticketsCost * 0.90;
            }

            double totalPrice = ticketsCost + extraTicketCost * tickets;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}