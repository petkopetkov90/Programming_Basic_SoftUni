using System;

namespace Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();

            string output = "";

            switch (day)
            {
                case "monday": 
                case "tuesday": 
                case "wednesday": 
                case "thursday": 
                case "friday":
                    output = "Working day"; break;
                case "saturday": 
                case "sunday": 
                    output = "Weekend"; break;
                default:
                    output = "Error"; break;
            }
            Console.WriteLine(output);
        }
    }
}