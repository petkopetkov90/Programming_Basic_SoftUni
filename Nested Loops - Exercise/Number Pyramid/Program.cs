using System;

namespace Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            bool over = false;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(num + " ");
                    num++;

                    if (num > n)
                    {
                        over = true;
                        break;
                    }
                }
                if (over)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}