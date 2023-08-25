using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 0;

            while (goal < 10000)
            {
                string stepsOrHome = Console.ReadLine();

                if (stepsOrHome == "Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    goal += stepsHome;
                    break;
                }

                int steps = int.Parse(stepsOrHome);

                goal += steps;
            }
            if (goal < 10000)
            {
                Console.WriteLine($"{10000 - goal} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{goal - 10000} steps over the goal!");
            }

        }
    }
}