using System;

namespace Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inc = double.Parse(Console.ReadLine());
            double centimeters = inc * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}