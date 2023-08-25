using System;

namespace Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingScore = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (startingScore <= 100)
            {
                bonus = 5;
            }
            else if (startingScore > 1000)
            {
                bonus = startingScore * 0.10;
            }
            else
            {
                bonus = startingScore * 0.20;
            }
            if (startingScore % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (startingScore % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(startingScore + bonus);
        }

    }
}

