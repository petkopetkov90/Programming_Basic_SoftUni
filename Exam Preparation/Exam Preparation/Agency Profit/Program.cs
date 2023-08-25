using System;

namespace Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int ticketsAdult = int.Parse(Console.ReadLine());
            int ticketsChildren = int.Parse(Console.ReadLine());
            double priceAdult = double.Parse(Console.ReadLine());
            double taxPerTicket = double.Parse(Console.ReadLine());

            double ticketPriceChildren = priceAdult * 0.30 + taxPerTicket;
            double ticketPriceAdult = priceAdult + taxPerTicket;

            double proffit = (ticketPriceChildren * ticketsChildren + ticketPriceAdult * ticketsAdult) * 0.20;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {proffit:f2} lv.");
        }
    }
}