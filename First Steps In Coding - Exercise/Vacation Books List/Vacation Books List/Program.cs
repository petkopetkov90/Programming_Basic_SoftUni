using System;

namespace Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());
            int hoursNeed = bookPages / pagesPerHour;
            int hoursPerDay = hoursNeed / daysToFinish;
            Console.WriteLine(hoursPerDay);
        }
    }
}