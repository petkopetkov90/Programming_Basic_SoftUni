using System;
using System.ComponentModel.Design;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int proects = int.Parse(Console.ReadLine());
            int workTime = proects * 3;

            Console.WriteLine($"The architect {architectName} will need {workTime} hours to complete {proects} project/s.");
            
        }
    }
}