using System;

namespace Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNums = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= totalNums; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                
                if (i % 2 == 00)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}