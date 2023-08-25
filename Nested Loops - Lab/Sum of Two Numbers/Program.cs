using System;

namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numStop = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;
            bool equal = false;

            for (int num1 = numStart; num1 <= numStop; num1++)
            {
                for (int num2 = numStart; num2 <= numStop; num2++)
                {
                    count++;
                    if (num1 + num2 == magicNum)
                    {
                        equal = true;
                        Console.WriteLine($"Combination N:{count} ({num1} + {num2} = {magicNum})");
                        break;
                    }
                }
                if (equal)
                {
                    break;
                }
            }
            if (!equal)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}