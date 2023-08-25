using System;
using System.Security.Cryptography.X509Certificates;

namespace Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            double totalRating = 0;
            double lowestRating = double.MaxValue;
            double highestRating = double.MinValue;
            string lowestMovie = string.Empty;
            string highestMovie = string.Empty;


            for (int i = 0; i < movies; i++)
            {
                string movie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                totalRating += rating;

                if (rating <= lowestRating)
                {
                    lowestRating = rating;
                    lowestMovie = movie;
                }
                if (rating >= highestRating)
                {
                    highestRating = rating;
                    highestMovie = movie;
                }

            }

            double averageRating = totalRating / movies;

            Console.WriteLine($"{highestMovie} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestMovie} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}