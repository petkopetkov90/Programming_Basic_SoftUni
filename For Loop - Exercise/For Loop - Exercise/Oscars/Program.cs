using System;
using System.Net.NetworkInformation;
using System.Xml.Schema;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            for (int i = 0; i < judges; i++)
            {
                string judgeName = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());

                double totalPointsFromJudge = judgeName.Length * pointsFromJudge / 2;
                points += totalPointsFromJudge;

                if (points >= 1250.50)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
            if (points  < 1250.50)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.50 - points:f1} more!");
            }

        }
    }
}