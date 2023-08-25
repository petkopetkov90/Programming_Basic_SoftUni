using System;

namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double total = 0.0;

            while (input != "NoMoreMoney")
            {
                double newSum = double.Parse(input);

                if (newSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {newSum:f2}");
                total += newSum;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}