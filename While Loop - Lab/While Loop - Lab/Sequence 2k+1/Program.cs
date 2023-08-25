using System;

namespace Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int newNum = 1;

            while (newNum <= num)
            {
                Console.WriteLine(newNum);
                newNum = newNum * 2 + 1;
            }
        }
    }
}