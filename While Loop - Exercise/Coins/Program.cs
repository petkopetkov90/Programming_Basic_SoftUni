using System;
using System.Xml.Schema;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double returnAmount = double.Parse(Console.ReadLine());

            int cent1 = 0;
            int cent2 = 0;
            int cent5 = 0;
            int cent10 = 0;
            int cent20 = 0;
            int cent50 = 0;
            int lv1 = 0;
            int lv2 = 0;

            while (returnAmount > 0)
            {
                if ((returnAmount - 2) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 2.00, 2);
                    lv2++;
                }
                else if((returnAmount - 1) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 1.00, 2);
                    lv1++;
                }
                else if ((returnAmount - 0.50) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 0.50, 2);
                    cent50++;
                }
                else if ((returnAmount - 0.20) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 0.20, 2);
                    cent20++;
                }
                else if ((returnAmount - 0.10) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 0.10, 2);
                    cent10++;
                }
                else if ((returnAmount - 0.05) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 0.05, 2);
                    cent5++;
                }
                else if ((returnAmount - 0.02) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 0.02, 2);
                    cent2++;
                }
                else if ((returnAmount - 0.01) >= 0)
                {
                    returnAmount = Math.Round(returnAmount - 0.01, 2);
                    cent5++;
                }
            }
            int totalCoins = cent1 + cent2 + cent5 + cent10 + cent20 + cent50 + lv1 + lv2;

            Console.WriteLine(totalCoins);
        }
    }
}