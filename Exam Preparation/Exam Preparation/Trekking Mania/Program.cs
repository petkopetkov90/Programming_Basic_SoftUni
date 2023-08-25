using System;

namespace Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double mussala = 0.0;
            double montBlanc = 0.0;
            double kilimandjaro = 0.0;
            double k2 = 0.0;
            double everest = 0.0;
            int totalPersons = 0;

            for (int i = 0; i < groups; i++)
            {
                int persons = int.Parse(Console.ReadLine());

                totalPersons += persons;

                if (persons <= 5)
                {
                    mussala += persons;
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

            double mussalaPercent = mussala / totalPersons * 100;
            double montBlancPercent = montBlanc / totalPersons * 100;
            double kilimandjaroPercent = kilimandjaro / totalPersons * 100;
            double k2Percent = k2 / totalPersons * 100;
            double everestPercent = everest / totalPersons * 100;

            Console.WriteLine($"{mussalaPercent:f2}%");
            Console.WriteLine($"{montBlancPercent:f2}%");
            Console.WriteLine($"{kilimandjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}