using System;

namespace High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int badJump = 0;
            int heightStart = height - 30;
            bool fail = false;
            int jumps = 0;

            while (!fail)
            {
                int jumpHeight = int.Parse((Console.ReadLine()));
                jumps++;

                if (jumpHeight <= heightStart)
                {
                    badJump++;

                    if (badJump >= 3)
                    {
                        fail = true;
                        break;
                    }
                }
                else
                {
                    badJump = 0;

                    if (jumpHeight > height && heightStart >= height)
                    {
                        break;
                    }
                    heightStart += 5;
                }

            }

            if (fail)
            {
                Console.WriteLine($"Tihomir failed at {heightStart}cm after {jumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {heightStart}cm after {jumps} jumps.");
            }
        }
    }
}