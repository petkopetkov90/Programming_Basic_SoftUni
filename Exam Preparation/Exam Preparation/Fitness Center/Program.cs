using System;
using System.Linq.Expressions;

namespace Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            int backTraning = 0;
            int chestTraning = 0;
            int legsTraning = 0;
            int AbsTraning = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 0; i < clients; i++)
            {
                string type = Console.ReadLine();

                switch (type)
                {
                    case "Back":
                        backTraning++;
                            break;
                    case "Chest":
                        chestTraning++;
                        break;
                    case "Legs":
                        legsTraning++;
                        break;
                    case "Abs":
                        AbsTraning++;
                        break;
                    case "Protein shake":
                        proteinShake++;
                        break;
                    case "Protein bar":
                        proteinBar++;
                        break;
                }
            }

            int clientsWorkout = backTraning + chestTraning + legsTraning + AbsTraning;
            double percentsWorkout = clientsWorkout * 100.00 / clients;
            double percentNoWorkout = 100.00 - percentsWorkout;

            Console.WriteLine($"{backTraning} - back");
            Console.WriteLine($"{chestTraning} - chest");
            Console.WriteLine($"{legsTraning} - legs");
            Console.WriteLine($"{AbsTraning} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentsWorkout:f2}% - work out");
            Console.WriteLine($"{percentNoWorkout:f2}% - protein");

        }
    }
}