using System;

namespace Oscars_ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double awards = rent * 0.70;
            double catering = awards * 0.85;
            double voicing = catering / 2;

            double totalExpenses = rent + awards + catering + voicing;

            Console.WriteLine($"{totalExpenses:f2}");
        }
    }
}