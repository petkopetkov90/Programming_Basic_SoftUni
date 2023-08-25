using System;

namespace Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comision = 0;

            bool isValid = (city == "sofia" || city == "varna" || city == "plovdiv") && sales >= 0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comision = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comision = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comision = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comision = sales * 0.12;
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comision = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comision = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comision = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    comision = sales * 0.13;
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comision = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comision = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comision = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comision = sales * 0.145;
                }
            }
            if (isValid)
            {
                Console.WriteLine($"{comision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}