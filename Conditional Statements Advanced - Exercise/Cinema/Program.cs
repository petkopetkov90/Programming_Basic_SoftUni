using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double places = rows * columns;
            string output = string.Empty;
            double price = 0;

            if (type == "premiere")
            {
                price = 12.00;
            }
            else if (type == "normal")
            {
                price = 7.50;
            }
            else
            {
                price = 5.00;
            }

            Console.WriteLine($"{price * places:f2} leva");

        }
    }
}