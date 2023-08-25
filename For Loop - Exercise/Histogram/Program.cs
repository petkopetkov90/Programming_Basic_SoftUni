using System;
using System.Xml;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNums = int.Parse(Console.ReadLine());

            double to200 = 0;
            double to400 = 0;
            double to600 = 0;
            double to800 = 0;
            double over = 0;

            for (int i = 0; i < totalNums; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    to200++;
                }
                else if (num < 400)
                {
                    to400++;
                }
                else if (num < 600)
                {
                    to600++;
                }
                else if (num < 800)
                {
                    to800++;
                }
                else
                {
                    over++;
                }
            }

            double to200percent = to200 / totalNums * 100;
            double to400percent = to400 / totalNums * 100;
            double to600percent = to600 / totalNums * 100;
            double to800percent = to800 / totalNums * 100;
            double overPercent = over / totalNums * 100;

            Console.WriteLine($"{to200percent:f2}%");
            Console.WriteLine($"{to400percent:f2}%");
            Console.WriteLine($"{to600percent:f2}%");
            Console.WriteLine($"{to800percent:f2}%");
            Console.WriteLine($"{overPercent:f2}%");
        }
    }
}