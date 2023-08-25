using System;

namespace Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());

            if (firstnumber >= secondnumber)
            {
                Console.WriteLine(firstnumber);
            }
            else
            {
                Console.WriteLine(secondnumber);
            }

        }
    }
}