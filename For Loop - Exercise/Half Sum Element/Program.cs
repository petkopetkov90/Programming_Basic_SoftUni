using System;

namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNums = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < totalNums; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            if (sum - maxNum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((sum-maxNum) - maxNum)}");
            }

        }
    }
}