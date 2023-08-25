using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());  // num = 1 to 600000

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            if (num % digit1 == 0 && num % digit2 == 0 && num % digit3 == 0 && num % digit4 == 0)
                            {
                                Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}