using System;

namespace Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int goalsBest = int.MinValue;
            string nameBest = string.Empty;

            while (!end)
            {
                string name = Console.ReadLine();

                if (name == "END")
                {
                    end = true;
                    break;
                }

                int goals = int.Parse(Console.ReadLine());

                if (goals > goalsBest)
                {
                    goalsBest = goals;
                    nameBest = name;                   
                }
                if (goals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{nameBest} is the best player!");

            if (goalsBest >= 3)
            {
                Console.WriteLine($"He has scored {goalsBest} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsBest} goals.");
            }
        }
    }
}