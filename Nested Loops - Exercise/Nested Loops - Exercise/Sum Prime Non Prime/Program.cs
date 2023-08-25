using System;

namespace Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numOrStop = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            bool nonPrime = false;

            while (numOrStop != "stop")
            {
                int num = int.Parse(numOrStop);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0 || num < 1)
                        {
                            nonPrime = true;
                            break;
                        }
                    }
                    if (nonPrime)
                    {
                        nonPrimeSum += num;
                        nonPrime = false;
                    }
                    else
                    {
                        primeSum += num;
                    }
                }
                numOrStop = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}