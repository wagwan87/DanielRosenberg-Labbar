using Labb12.Manager;
using Labb12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class Runtime
    {
        public void Start()
        {
            MovieManager moviemanager = new MovieManager();

            bool loop = true;



            do
            {
                Console.Clear();
                Console.WriteLine(Movie.MovieFormat1() + Environment.NewLine);

                foreach (var movie in moviemanager.Movies)
                {
                    Console.WriteLine(movie.MovieFormat2());
                }

                UI.DrawMainMenu();
                var userInput = Console.ReadKey(true).Key;
                Console.WriteLine();

                switch (userInput)
                {
                    case ConsoleKey.D1:
                        moviemanager.GetOneMovie();
                        break;

                    case ConsoleKey.D2:
                        moviemanager.GetCategory();
                        break;

                    case ConsoleKey.D3:
                        moviemanager.GetMoviesUnder2h();
                        break;

                    case ConsoleKey.D4:
                        moviemanager.CreateArray();
                        break;

                    case ConsoleKey.D5:
                        moviemanager.CreateStringOfMovieTitle();
                        break;

                    case ConsoleKey.D6:
                        moviemanager.SpecialFilter();
                        break;

                    case ConsoleKey.D7:
                        Environment.Exit(0);
                        break;

                }
                Console.ReadKey();

            } while (loop);
        }
    }
}
