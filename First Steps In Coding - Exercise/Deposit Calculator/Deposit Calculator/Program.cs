using System;
using System.Runtime.CompilerServices;

namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double sum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double interestSum = ((sum * (interest / 100)) / 12) * time;
            Console.WriteLine(sum + interestSum);
        }
    }
}