using System;

namespace Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            bool valid = (num >= 100 && num <= 200) || num == 0;

            if (!valid)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}