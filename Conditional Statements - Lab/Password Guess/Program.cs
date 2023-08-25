using System;

namespace Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string correctpassword = "s3cr3t!P@ssw0rd";

            if (password == correctpassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}