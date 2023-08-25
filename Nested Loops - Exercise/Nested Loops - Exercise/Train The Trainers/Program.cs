using System;

namespace Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int referees = int.Parse(Console.ReadLine());

            bool notFinish = true;
            double tasks = 0;
            double gradesFromAllTasks = 0;

            while (notFinish)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Finish")
                {
                    double finalGrade = gradesFromAllTasks / tasks;
                    Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");
                    notFinish = false;
                    break;
                }

                double totalGrade = 0;

                for (int i = 0; i < referees; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalGrade += grade;
                }
                Console.WriteLine($"{taskName} - {totalGrade / referees:f2}.");
                gradesFromAllTasks += (totalGrade / referees);
                tasks++;
            }
        }
    }
}