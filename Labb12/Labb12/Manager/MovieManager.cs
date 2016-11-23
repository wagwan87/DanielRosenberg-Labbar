using Labb12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12.Manager
{
    class MovieManager
    {
        public List<Movie> Movies { get; set; }

        public MovieManager()
        {
            Movies = new List<Movie>()
            {
                new Movie {Title = "The pick of destiny", Category = Movie.Categories.Comedy , Length = 100 },
                new Movie {Title = "Hot fuzz", Category = Movie.Categories.Comedy , Length = 130 },
                new Movie {Title = "The conjuring", Category = Movie.Categories.Horror , Length = 140 },
                new Movie {Title = "Shaun of the dead", Category = Movie.Categories.Comedy , Length = 120 },
                new Movie {Title = "Requiem for a dream", Category = Movie.Categories.Drama , Length = 150 },
                new Movie {Title = "Donnie darko", Category = Movie.Categories.Drama , Length = 90 },
                new Movie {Title = "Halloween", Category = Movie.Categories.Horror , Length = 130 },
                new Movie {Title = "The lord of the rings", Category = Movie.Categories.Fantasy , Length = 180 },
                new Movie {Title = "The force awakens", Category = Movie.Categories.Fantasy , Length = 150 },
                new Movie {Title = "The silence of the lambs", Category = Movie.Categories.Thriller , Length = 120 },
                new Movie {Title = "Seven", Category = Movie.Categories.Thriller , Length = 100 },
                new Movie {Title = "Shutter island", Category = Movie.Categories.Thriller , Length = 90 },
            };
        }

        public void GetMoviesUnder2h()
        {
            List<Movie> movies = Movies
                .Where(movie => movie.Length < 120).ToList();

            Console.WriteLine(Movie.MovieFormat1());

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.MovieFormat2());
            }
        }

        public void GetCategory()
        {
            foreach (var category in Enum.GetValues(typeof(Movie.Categories)))
            {
                Console.WriteLine("{0} - {1}", (int)category, category);
            }

            Console.WriteLine("Category: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Movie.MovieFormat1());

            try
            {
                List<Movie> movies = Movies.Where(movie => movie.Category == (Movie.Categories)input).ToList();
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.MovieFormat2());
                }
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void GetOneMovie()
        {
            Console.Write("Please select a movie title: ");
            string input = Console.ReadLine();

            Movie oneMovie = Movies
                .Where(movie => String.Equals(movie.Title, input))
                .SingleOrDefault();

            if (oneMovie == null)
                Console.WriteLine("No movie match the description.");
            else
                Console.WriteLine("One movie found: {0}", oneMovie.MovieFormat2());
        }

        public void CreateStringOfMovieTitle()
        {
            Console.Write("Select a title: ");
            string input = Console.ReadLine();

            string titleOfMovie = Movies
                .Where(movie => movie.Title.Equals(input))
                .Select(movie => movie.Title)
                .FirstOrDefault();

            if (!(String.IsNullOrEmpty(titleOfMovie)))
            {
                Console.WriteLine("Result: (movie title): {0}", titleOfMovie);
            }
            else
                Console.WriteLine("No movie found.");
        }


        public void CreateArray()
        {
            string[] titleofMovie = Movies
                .Select(movie => movie.Title).ToArray();

            foreach (var title in titleofMovie)
            {
                Console.WriteLine(title);
            }
        }

        public void SpecialFilter()
        {
            Console.Write("What letter does the movie start with?");
            string letter = Console.ReadLine();

            Console.Write("The minimum length of the movie: ");
            int length = int.Parse(Console.ReadLine());

            foreach (var category in Enum.GetValues(typeof(Movie.Categories)))
            {
                Console.WriteLine("{0} - {1}", (int)category, category);
            }

            Console.Write("Select category: ");
            int inputCategory = int.Parse(Console.ReadLine());

            List<Movie> movies = Movies
                .Where(movie => (String.Equals(movie.Title[0], letter[0])) && (length <= movie.Length) && (movie.Category == (Movie.Categories)inputCategory))
                .ToList();

            if (!(movies.Count == 0))
            {
                Console.WriteLine("Result:");

                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.MovieFormat2());
                }
            }
            else
                Console.WriteLine("Sorry no movies matched your criteria.");

        }
    }
}

