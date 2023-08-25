using System;

namespace Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contractYearOrTwo = Console.ReadLine().ToLower();
            string contractType = Console.ReadLine().ToLower();
            string internetYesOrNo = Console.ReadLine().ToLower();
            int monthsToPay = int.Parse(Console.ReadLine());

            double contractCostPerMont = 0;

            if (contractYearOrTwo == "one")
            {
                switch (contractType)
                {
                    case "small": contractCostPerMont = 9.98; break;
                    case "middle": contractCostPerMont = 18.99; break;
                    case "large": contractCostPerMont = 25.98; break;
                    case "extralarge": contractCostPerMont = 35.99; break;
                }
            }
            else
            {
                switch (contractType)
                {
                    case "small": contractCostPerMont = 8.58; break;
                    case "middle": contractCostPerMont = 17.09; break;
                    case "large": contractCostPerMont = 23.59; break;
                    case "extralarge": contractCostPerMont = 31.79; break;
                }
            }
            if (internetYesOrNo == "yes")
            {
                if (contractCostPerMont < 10)
                {
                    contractCostPerMont += 5.50;
                }
                else if (contractCostPerMont < 30)
                {
                    contractCostPerMont += 4.35;
                }
                else
                {
                    contractCostPerMont += 3.85;
                }
            }
            if (contractYearOrTwo == "two")
            {
                contractCostPerMont = contractCostPerMont - contractCostPerMont * 0.0375;
            }

            double totalPrice = contractCostPerMont * monthsToPay;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}