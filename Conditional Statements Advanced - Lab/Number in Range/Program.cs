using System;

namespace Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            bool yes = num >= -100 && num <= 100 && num != 0;
            string output = string.Empty;

            if (yes)
            {
                output = "Yes";
            }
            else
            {
                output = "No";
            }
            Console.WriteLine(output);
        }
    }
}