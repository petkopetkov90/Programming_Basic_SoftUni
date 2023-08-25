using System;

namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            int badGradesCounter = 0;
            double grades = 0.0;
            double tasks = 0.0;
            string lastTask = string.Empty;

            while (badGradesCounter < badGrades)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4.00)
                {
                    badGradesCounter++;
                }

                tasks++;
                grades += grade;
                lastTask = taskName;
            }

            if (badGradesCounter >= badGrades)
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(grades / tasks):f2}");
                Console.WriteLine($"Number of problems: {tasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}