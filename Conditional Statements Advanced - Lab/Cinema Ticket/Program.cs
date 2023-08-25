using System;

namespace Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();

            double price = 0;

            switch (day)
            {
                case "monday":
                case "tuesday":
                case "friday":
                    price = 12; break;
                case "wednesday":
                case "thursday":
                    price = 14; break;
                case "saturday":
                case "sunday":
                    price = 16; break;
            }
            Console.WriteLine(price);
        }
    }
}