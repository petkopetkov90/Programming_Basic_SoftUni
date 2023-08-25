using System;

namespace Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 1;

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(total);
                    total = total * 2 * 2;
                }              
            }
            
        }
    }
}