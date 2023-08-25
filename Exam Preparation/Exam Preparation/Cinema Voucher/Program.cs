using System;

namespace Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            bool end = false;

            double totalPurchases = 0;
            int purchaseCount = 0;
            int ticketsCount = 0;

            while (!end)
            {
                string purchase = Console.ReadLine();

                if (purchase == "End")
                {
                    end = true;
                    break;
                }

                double amount = 0;
          
                if (purchase.Length > 8)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        amount += purchase[i];
                    }

                    ticketsCount++;
                }
                else
                {
                    amount = purchase[0];
                    purchaseCount++;
                }

                totalPurchases += amount;

                if (totalPurchases > voucher)
                {
                    if(purchase.Length > 8)
                    {
                        ticketsCount--;
                    }
                    else
                    {
                        purchaseCount--;
                    }
                    break;
                }

            }

            Console.WriteLine(ticketsCount);
            Console.WriteLine(purchaseCount);
        }
    }
}