using System;

namespace Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pricePerDay = 0.0;

            if (season == "Winter")
            {
                switch (destination)
                {
                    case "Dubai": pricePerDay = 45000; break;
                    case "Sofia": pricePerDay = 17000; break;
                    case "London": pricePerDay = 24000; break;
                }
            }
            else if (season == "Summer")
            {
                switch (destination)
                {
                    case "Dubai": pricePerDay = 40000; break;
                    case "Sofia": pricePerDay = 12500; break;
                    case "London": pricePerDay = 20250; break;
                }
            }

            double totalPrice = days * pricePerDay;

            if (destination == "Dubai")
            {
                totalPrice = totalPrice * 0.70;
            }
            else if (destination == "Sofia")
            {
                totalPrice = totalPrice * 1.25;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
            }
        }
    }
}