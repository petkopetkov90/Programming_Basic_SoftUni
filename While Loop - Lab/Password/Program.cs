using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            
            while (true)
            {
                string newPass = Console.ReadLine();
                if (newPass == pass)
                {
                    Console.WriteLine($"Welcome {name}!");
                    break;
                }
            }
        }
    }
}