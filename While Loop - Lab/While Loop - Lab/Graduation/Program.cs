using System;
using System.Runtime.ExceptionServices;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double atClass = 1;
            double totalGrades = 0;
            int badGrade = 0;

            while (atClass <= 12)
            {
                if (badGrade >= 2)
                {
                    break;
                }

                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    badGrade++;
                    continue;
                }

                totalGrades += grade;
                atClass++;
            }
            if (badGrade >= 2)
            {
                Console.WriteLine($"{name} has been excluded at {atClass} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {(totalGrades / 12):f2}");
            }
        }
    }
}