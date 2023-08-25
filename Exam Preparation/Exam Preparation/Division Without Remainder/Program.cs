using System;

namespace Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());

            int numbersOn2 = 0;
            int numbersOn3 = 0;
            int numbersOn4 = 0;
            
            for (int i = 0; i < totalNumbers; i++)
            {
                int newNum = int.Parse(Console.ReadLine());

                if (newNum % 2 == 0)
                {
                    numbersOn2++;
                }
                if (newNum % 3 == 0)
                {
                    numbersOn3++;
                }
                if (newNum % 4 == 0)
                {
                    numbersOn4++;
                }
            }

            double numbersOn2Percent = numbersOn2 * 100.00 / totalNumbers;
            double numbersOn3Percent = numbersOn3 * 100.00 / totalNumbers;
            double numbersOn4Percent = numbersOn4 * 100.00 / totalNumbers;

            Console.WriteLine($"{numbersOn2Percent:f2}%");
            Console.WriteLine($"{numbersOn3Percent:f2}%");
            Console.WriteLine($"{numbersOn4Percent:f2}%");
        }
    }
}