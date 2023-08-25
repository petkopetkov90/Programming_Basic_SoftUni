using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stundents = int.Parse(Console.ReadLine());

            int under3 = 0;
            int under4 = 0;
            int under5 = 0;
            int topGrade = 0;

            double totalGrades = 0;

            for (int i = 0; i < stundents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                totalGrades += grade;

                if (grade < 3)
                {
                    under3++;
                }
                else if (grade < 4)
                {
                    under4++;
                }
                else if (grade < 5)
                {
                    under5++;
                }
                else
                {
                    topGrade++;
                }
            }

            double averageGrade = totalGrades / stundents;

            double under3Percent = under3 * 100.00 / stundents;
            double under4Percent = under4 * 100.00 / stundents;
            double under5Percent = under5 * 100.00 / stundents;
            double topPercent = topGrade * 100.00 / stundents;

            Console.WriteLine($"Top students: {topPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {under5Percent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {under4Percent:f2}%");
            Console.WriteLine($"Fail: {under3Percent:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}