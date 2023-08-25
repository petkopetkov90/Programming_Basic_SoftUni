using System;

namespace Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string type = Console.ReadLine();

            double gradeHard = 0;
            double gradePerform = 0;

            if (country == "Russia")
            {
                if (type == "ribbon")
                {
                    gradeHard = 9.100;
                    gradePerform = 9.400;
                }
                else if (type == "hoop")
                {
                    gradeHard = 9.300;
                    gradePerform = 9.800;
                }
                else if (type == "rope")
                {
                    gradeHard = 9.600;
                    gradePerform = 9.000;
                }
            }
            else if (country == "Bulgaria")
            {
                if (type == "ribbon")
                {
                    gradeHard = 9.600;
                    gradePerform = 9.400;
                }
                else if (type == "hoop")
                {
                    gradeHard = 9.550;
                    gradePerform = 9.750;
                }
                else if (type == "rope")
                {
                    gradeHard = 9.500;
                    gradePerform = 9.400;
                }
            }
            else if (country == "Italy")
            {
                if (type == "ribbon")
                {
                    gradeHard = 9.200;
                    gradePerform = 9.500;
                }
                else if (type == "hoop")
                {
                    gradeHard = 9.450;
                    gradePerform = 9.350;
                }
                else if (type == "rope")
                {
                    gradeHard = 9.700;
                    gradePerform = 9.150;
                }
            }

            double totalGrade = gradeHard + gradePerform;
            double percentNeed = ((20.00 - totalGrade) / 20.00) * 100.00;

            Console.WriteLine($"The team of {country} get {totalGrade:f3} on {type}.");
            Console.WriteLine($"{percentNeed:f2}%");
        }
    }
}