using System;

namespace Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();

            string type = string.Empty;

            switch (name)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    type = "fruit"; break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    type = "vegetable"; break;
                default:
                    type = "unknown"; break;
            }
            Console.WriteLine(type);
        }
    }
}