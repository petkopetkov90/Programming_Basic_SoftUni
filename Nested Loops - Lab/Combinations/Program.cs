using System;

namespace Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int count = 0;

            for (int x = 0; x <= num; x++)
            {
                for (int y = 0; y <= num; y++)
                {
                    for (int z = 0; z <= num; z++)
                    {
                        int result = x + y + z;

                        if (result == num)
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}