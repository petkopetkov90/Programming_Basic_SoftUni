using System;

namespace Movie_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2 - 1; i++)
            {
                char char1 = Convert.ToChar(i);

                for (int j = 1; j <= num3 - 1; j++)
                {
                    int char2 = j;

                    for(int k = 1; k <= num3 / 2 - 1; k++)
                    {
                        int char3 = k;
                        int char4 = (int)char1;

                        string ticket = $"{char1}-{char2}{char3}{char4}";

                        if (char4 % 2 != 0 && (char2 + char3 + char4) % 2 != 0)
                        {
                            Console.WriteLine(ticket);
                        }
                    }
                }            
            }
        }
    }
}