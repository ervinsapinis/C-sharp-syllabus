using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie bondMovie = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie glassMovie = new Movie("Glass", "Buena Vista International", "PG13");
            Movie spiderMovie = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            Movie batMovie = new Movie("Batman", "Columbia Pictures", "PG");

            Movie[] allmMovies = {bondMovie, glassMovie, spiderMovie, batMovie};
            Movie[] filteredMovies = GetPG(allmMovies);
            foreach (Movie movie in filteredMovies)
            {
                Console.WriteLine(movie.DisplayInfo());
            }

        }
        public static Movie[] GetPG(Movie[] movies)
        {
            var pgMovies = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Rating == "PG")
                {
                    pgMovies.Add(movie);
                }    
            }
            return pgMovies.ToArray();
        }
    }
}
