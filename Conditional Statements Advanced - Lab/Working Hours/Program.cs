using System;

namespace Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine().ToLower();

            string output = string.Empty;

            if ((day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday" || day == "saturday") && (hour >= 10 && hour <= 18))
            {
                output = "open";
            }
            else
            {
                output = "closed";
            }
            Console.WriteLine(output);
        }
    }
}