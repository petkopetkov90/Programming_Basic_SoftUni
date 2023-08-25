using System;

namespace Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentCinema = int.Parse(Console.ReadLine());
            
            double incnome = days * tickets * ticketPrice;
            double profit = incnome - (incnome / 100 * percentCinema);

            Console.WriteLine($"The profit from the movie {name} is {profit:f2} lv.");
        }
    }
}