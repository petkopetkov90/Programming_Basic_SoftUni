using System;
using System.Runtime.ExceptionServices;

namespace Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); // 111 to 999

            int firstNum = num % 10;
            num = num / 10;
            int secondNum = num % 10;
            int lastNum = num / 10;

            for (int num1 = 1; num1 <= firstNum; num1++)
            {
                for (int num2 = 1; num2 <= secondNum; num2++)
                {
                    for (int num3 = 1; num3 <= lastNum; num3++)
                    {
                        if (num1 > 0 && num2 > 0 && num3 > 0)
                        {
                            int result = num1 * num2 * num3;
                            Console.WriteLine($"{num1} * {num2} * {num3} = {result};");
                        }
                    }
                }
            }
        }
    }
}