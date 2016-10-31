using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("1 - Games");
            Console.WriteLine("2 - Movies");
            Console.WriteLine("3 - Exit");
        }

        public static void PrintGameMenu()
        {
            Console.WriteLine("1 - Add game");
            Console.WriteLine("2 - Edit game");
            Console.WriteLine("3 - Remove game");
            Console.WriteLine("4 - Show all games");
        }

        public static Game CreateGame()
        {
            Game newGame = new Game();
            Console.Clear();
            Console.WriteLine("Choose game name: ");
            newGame.GameName = Console.ReadLine();

            Console.WriteLine("Game genres: ");
            PrintGamesGenre();
            Console.Write("Select a genre: ");
            int input = int.Parse(Console.ReadLine());
            newGame.GameGenre = (Game.GameGenreType)input;

            return newGame;
        }

        public static void EditGame(Game game)
        {
            Console.Clear();
            Console.WriteLine("1 - Change name");
            Console.WriteLine("2 - Change genre");
            Console.Write("Choice: ");
            var input = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Game: {0}. Genre: {1}", game.GameName, game.GameGenre);

            switch (input)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    game.GameName = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Genre list");
                    PrintGamesGenre();
                    Console.Write("New genre: ");
                    game.GameGenre = (Game.GameGenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static int SelectGame(Game[] games)
        {
            PrintGameList(games);
            Console.Write("Select a game: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintGamesGenre()
        {
            foreach (var genre in Enum.GetValues(typeof(Game.GameGenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintGameList(Game[] games)
        {
            Console.Clear();
            foreach (var game in games)
            {
                Console.WriteLine("{0}. Game: {1}, Genre: {2}", Array.IndexOf(games, game) + 1,
                    game.GameName, game.GameGenre);
            }
        }

        public static void PrintMovieMenu()
        {
            Console.WriteLine("1 - Add movie");
            Console.WriteLine("2 - Edit movie");
            Console.WriteLine("3 - Remove movie");
            Console.WriteLine("4 - Show all movies");
        }

        public static Movie CreateMovie()
        {
            Movie newMovie = new Movie();
            Console.Clear();
            Console.WriteLine("Choose movie name: ");
            newMovie.MovieName = Console.ReadLine();

            Console.WriteLine("Movie genres: ");
            PrintMoviesGenre();
            Console.Write("Select a genre: ");
            int input = int.Parse(Console.ReadLine());
            newMovie.MovieGenre = (Movie.MovieGenreType)input;

            return newMovie;
        }

        public static void EditMovie(Movie movie)
        {
            Console.Clear();
            Console.WriteLine("1 - Change name");
            Console.WriteLine("2 - Change genre");
            Console.Write("Choice: ");
            var input = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Movie: {0}. Genre: {1}", movie.MovieName, movie.MovieGenre);

            switch (input)
            {
                case ConsoleKey.D1:
                    Console.Write("New name");
                    movie.MovieName = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Genre list");
                    PrintMoviesGenre();
                    Console.Write("New genre: ");
                    movie.MovieGenre = (Movie.MovieGenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static int SelectMovie(Movie[] movies)
        {
            PrintMovieList(movies);
            Console.Write("Select a movie: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintMoviesGenre()
        {
            foreach (var genre in Enum.GetValues(typeof(Movie.MovieGenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintMovieList(Movie[] movies)
        {
            Console.Clear();
            foreach (var movie in movies)
            {
                Console.WriteLine("{0}. Movie: {1}, Genre: {2}", Array.IndexOf(movies, movie) + 1,
                    movie.MovieName, movie.MovieGenre);
            }
        }
    }
}

