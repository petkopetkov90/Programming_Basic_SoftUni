using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            int daysSpend = 0;
            int days = 0;


            while (moneyHave < vacationCost && daysSpend < 5)
            {
                string spendOrSave = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                days++;

                if (spendOrSave == "spend" && moneyHave > sum)
                {
                    moneyHave -= sum;
                    daysSpend += 1;
                }
                else if (spendOrSave == "spend" && moneyHave <= sum)
                {
                    moneyHave = 0;
                    daysSpend += 1;
                }
                else
                {
                    moneyHave += sum;
                    daysSpend = 0;
                }
            }
            if (moneyHave >= vacationCost)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}