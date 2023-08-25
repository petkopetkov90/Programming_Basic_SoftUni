using System;
using System.Xml;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string tab = Console.ReadLine();

                if (tab == "Facebook")
                {
                    salary = salary - 150;
                }
                if (tab == "Instagram")
                {
                    salary = salary - 100;
                }
                if (tab == "Reddit")
                {
                    salary = salary - 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}