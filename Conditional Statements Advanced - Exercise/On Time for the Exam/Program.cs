using System;

namespace On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minArrival = int.Parse(Console.ReadLine());

            string studentIs = string.Empty;
            int timeInMinExam = hourExam * 60 + minExam;
            int timeInMinArrival = hourArrival * 60 + minArrival;
            string outputdiff = string.Empty;
            int timeDiff = Math.Abs(timeInMinArrival - timeInMinExam);
            int hoursDiff = timeDiff / 60;
            int minDiff = timeDiff % 60;

            if (timeInMinArrival > timeInMinExam)
            {
                studentIs = "Late";

                if (timeDiff >= 60)
                {
                    if (minDiff < 10)
                    {
                        outputdiff = $"{hoursDiff}:0{minDiff} hours after the start";
                    }
                    else
                    {
                        outputdiff = $"{hoursDiff}:{minDiff} hours after the start";
                    }
                }
                else
                {
                    outputdiff = $"{minDiff} minutes after the start";
                }
            }
            else if (timeInMinExam > timeInMinArrival)
            {
                if (timeDiff >= 60)
                {
                    if(minDiff < 10)
                    {
                        outputdiff = $"{hoursDiff}:0{minDiff} hours before the start";
                    }
                    else
                    {
                        outputdiff = $"{hoursDiff}:{minDiff} hours before the start";
                    }
                }
                else
                {
                    outputdiff = $"{minDiff} minutes before the start";
                }
                if (timeDiff > 30)
                {
                    studentIs = "Early";
                }
                else
                {
                    studentIs = "On time";
                }
            }          
            if (timeInMinArrival == timeInMinExam)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine(studentIs);
                Console.WriteLine(outputdiff);
            }
        }
    }
}