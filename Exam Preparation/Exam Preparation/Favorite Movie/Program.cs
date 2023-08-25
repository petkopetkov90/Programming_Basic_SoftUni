using System;

namespace Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool stop = false;

            string bestMovie = string.Empty;
            int bestScore = int.MinValue;
            int movieCounter = 0;

            while (!stop)
            {
                string movieName = Console.ReadLine();

                movieCounter++;

                if (movieName == "STOP")
                {
                    stop = true;
                    break;
                }

                int movieScore = 0;

                for (int i = 0; i < movieName.Length; i++)
                {
                    movieScore += movieName[i];

                    bool upper = Char.IsUpper(movieName[i]);

                    bool lower = Char.IsLower(movieName[i]);

                    if (upper)
                    {
                        movieScore = movieScore - movieName.Length;
                    }
                    else if (lower)
                    {
                        movieScore = movieScore - (movieName.Length * 2);
                    }
                }

                if (bestScore < movieScore)
                {
                    bestScore = movieScore;
                    bestMovie = movieName;
                }

                if (movieCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {bestScore} ASCII sum.");
        }
    }
}