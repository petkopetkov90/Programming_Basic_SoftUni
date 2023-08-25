using System;

namespace Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double proffitWanted = double.Parse(Console.ReadLine());

            bool party = false;

            double proffit = 0.0;

            while (!party)
            {
                string drink = Console.ReadLine();

                if (drink == "Party!")
                {
                    party = true;
                    break;
                }

                int drinks = int.Parse(Console.ReadLine());

                double drinkPrice = drink.Length;

                double order = drinks * drinkPrice;

                if (order % 2 == 1)
                {
                    order = order * 0.75;
                }

                proffit += order;

                if (proffit >= proffitWanted)
                {
                    break;
                }
            }

            if (party)
            {
                Console.WriteLine($"We need {proffitWanted - proffit:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {proffit:f2} leva.");
        }
    }
}