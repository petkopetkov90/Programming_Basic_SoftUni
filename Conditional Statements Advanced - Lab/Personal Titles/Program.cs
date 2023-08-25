using System;

namespace Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            string output = string.Empty;

            if (gender == "m")
            {
                if (age < 16)
                {
                    output = "Master";
                }
                else
                {
                    output = "Mr.";
                }
            }
            else if (gender == "f")
            {
                if (age < 16)
                {
                    output = "Miss";
                }
                else
                {
                    output = "Ms.";
                }
            }
            Console.WriteLine(output);
        }
    }
}