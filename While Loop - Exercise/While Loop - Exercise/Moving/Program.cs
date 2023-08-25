using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int placeWide = int.Parse(Console.ReadLine());
            int placeLong = int.Parse(Console.ReadLine());
            int placeHeight = int.Parse(Console.ReadLine());

            int placeCubic = placeWide * placeLong * placeHeight;

            int boxPlace = 0;

            while (boxPlace < placeCubic)
            {
                string boxOrDone = Console.ReadLine();

                if (boxOrDone == "Done")
                {
                    break;
                }

                int boxes = int.Parse(boxOrDone);
                boxPlace += boxes;

            }

            if (boxPlace >= placeCubic)
            {
                Console.WriteLine($"No more free space! You need {boxPlace - placeCubic} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{placeCubic - boxPlace} Cubic meters left.");
            }
        }
    }
}