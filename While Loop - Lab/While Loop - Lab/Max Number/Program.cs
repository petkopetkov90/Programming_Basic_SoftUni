using System;
using System.Diagnostics;

namespace Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int maxNum = int.MinValue;

            while (input != "Stop")
            {
               int num = int.Parse(input);

                if (num > maxNum )
                {
                    maxNum = num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNum);
        }
    }
}