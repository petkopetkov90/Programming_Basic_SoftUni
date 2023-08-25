using System;
using System.Security.Cryptography;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int totalTickets = 0;
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;

            while (movieName != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();

                int tickets = 0;

                while (ticketType != "End")
                {
                    tickets++;

                    if (ticketType == "student")
                    {
                        totalStudent++;
                    }
                    else if (ticketType == "standard")
                    {
                        totalStandard++;
                    }
                    else if (ticketType == "kid")
                    {
                        totalKid++;
                    }

                    if (tickets >= seats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();

                }

                totalTickets += tickets;

                double percetsFull = tickets * 100.00 / seats;

                Console.WriteLine($"{movieName} - {percetsFull:f2}% full.");

                movieName = Console.ReadLine();
            }

            double StudentPercent = totalStudent * 100.00 / totalTickets;
            double StandardPercent = totalStandard * 100.00 / totalTickets;
            double kidPercent = totalKid * 100.00 / totalTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{StudentPercent:f2}% student tickets.");
            Console.WriteLine($"{StandardPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidPercent:f2}% kids tickets.");

        }
    }
}