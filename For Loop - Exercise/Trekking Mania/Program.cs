using System;
using System.Xml.Schema;

namespace Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double musala = 0;
            double montBlanc = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 0; i < groups; i++)
            {
                int persons = int.Parse(Console.ReadLine());

                if (persons <= 5)
                {
                    musala += persons;
                }
                else if (persons <= 12)
                {
                    montBlanc += persons;
                }
                else if (persons <= 25)
                {
                    kilimandjaro += persons;
                }
                else if (persons <= 40)
                {
                    k2 += persons;
                }
                else
                {
                    everest += persons;
                }
            }
            double totalPersons = musala + montBlanc + kilimandjaro + k2 + everest;
            double musalaPercent = musala / totalPersons * 100;
            double montBlancPercent = montBlanc / totalPersons * 100;
            double kilimandjaroPercent = kilimandjaro / totalPersons * 100;
            double k2Percent = k2 / totalPersons * 100;
            double everestPercent = everest / totalPersons * 100;

            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{montBlancPercent:f2}%");
            Console.WriteLine($"{kilimandjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");

        }
    }
}