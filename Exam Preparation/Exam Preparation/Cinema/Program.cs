using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomSeats = int.Parse(Console.ReadLine());

            bool movieTime = false;

            int ticketPrice = 5;
            int totalTickets = 0;

            int profit = 0;
            

            while (!movieTime)
            {
                string movieTimeOrTickets = Console.ReadLine();
                int discount = 0;

                if (movieTimeOrTickets == "Movie time!")
                {
                    movieTime = true;
                    break;
                }

                int tickets = int.Parse(movieTimeOrTickets);

                if (tickets % 3 == 0)
                {
                    discount = 5;
                }

                totalTickets += tickets;

                if (totalTickets > roomSeats)
                {
                    break;
                }

                int price = ticketPrice * tickets - discount;

                profit += price;

            }

            if (movieTime)
            {
                Console.WriteLine($"There are {roomSeats - totalTickets} seats left in the cinema.");
            }
            else
            {
                Console.WriteLine("The cinema is full.");
            }

            Console.WriteLine($"Cinema income - {profit} lv.");

        }
    }
}