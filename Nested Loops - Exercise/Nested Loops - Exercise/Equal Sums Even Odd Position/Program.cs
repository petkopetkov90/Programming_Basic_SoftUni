using System;
using System.Runtime.InteropServices;

namespace Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1 ; i <= num2; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                int num = i;

                string currentSum = i.ToString();

                for (int j = 1; j <= currentSum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum = evenSum + num % 10;
                    }
                    else
                    {
                        oddSum = oddSum + num % 10;
                    }
                    num = num / 10;
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}