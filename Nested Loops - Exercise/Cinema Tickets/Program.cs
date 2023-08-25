using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine();

            double totalTickets = 0.0;
            double studentTickets = 0.0;
            double standardTickets = 0.0;
            double kidTickets = 0.0;

            while (movieName != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());

                double totalTickesPerMovie = 0.0;

                for (int i = 1; i <= seats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    else
                    {
                        totalTickesPerMovie++;

                        if (ticketType == "student")
                        {
                            studentTickets++;
                        }
                        else if (ticketType == "standard")
                        {
                            standardTickets++;
                        }
                        else if (ticketType == "kid")
                        {
                            kidTickets++;
                        }

                    }
                }
                totalTickets += totalTickesPerMovie;
                Console.WriteLine($"{movieName} - {totalTickesPerMovie / seats * 100:f2}% full.");

                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}