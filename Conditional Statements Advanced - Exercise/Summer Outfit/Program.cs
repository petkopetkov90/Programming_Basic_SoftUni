using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string periodOfDay = Console.ReadLine().ToLower();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if (periodOfDay == "morning")
            {
                if (degrees <= 18 && degrees >= 10)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (periodOfDay == "afternoon")
            {
                if (degrees <= 18 && degrees >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees > 24)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else  
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}