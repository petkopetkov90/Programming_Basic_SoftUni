using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            string output = string.Empty;

            switch (animal)
            {
                case "dog": 
                    output = "mammal"; break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    output = "reptile"; break;
                default:
                    output = "unknown"; break;
            }
            Console.WriteLine(output);
        }
    }
}