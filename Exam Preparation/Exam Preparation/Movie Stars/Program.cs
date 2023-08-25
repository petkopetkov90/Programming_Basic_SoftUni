using System;

namespace Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            bool haveMoney = true;
            double totalPaychecks = 0.0;

            while (haveMoney)
            {
                string name = Console.ReadLine();
                double salary = 0.0;
                if (name == "ACTION")
                {
                    break;
                }
                if (name.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    salary = (budget - totalPaychecks) * 0.20;
                }

                totalPaychecks += salary;

                if (totalPaychecks > budget)
                {
                    haveMoney = false;
                    break;
                }
            }
            if (!haveMoney)
            {
                Console.WriteLine($"We need {totalPaychecks - budget:f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget - totalPaychecks:f2} leva.");
            }

        }
    }
}