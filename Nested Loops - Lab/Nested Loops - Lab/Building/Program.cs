using System;
using System.Xml;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int row = floors; row >= 1; row--)
            {
                if (row == floors)
                {
                    for (int col = 0; col < rooms; col++)
                    {
                        Console.Write($"L{row}{col} ");
                    }
                }
                else if (row % 2 == 0)
                {
                    for (int col = 0; col < rooms; col++)
                    {
                        Console.Write($"O{row}{col} ");
                    }
                }
                else
                {
                    for (int col = 0; col < rooms; col++)
                    {
                        Console.Write($"A{row}{col} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}