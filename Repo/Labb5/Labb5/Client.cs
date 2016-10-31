using Labb5.Controllers;
using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Client
    {
        public void Start()
        {
       
            var loop = true;

            while (loop)
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        UI.PrintGameMenu();
                        GameSwitch();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        UI.PrintMovieMenu();
                        MovieSwitch();
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;

                    default:
                        loop = true;
                        break;

                }

            }

        }
        public void GameSwitch()
        {
            var games = new GamesController();
            var loop = true;

            while(loop)
            {
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        games.CreateGame();
                        UI.PrintGameMenu();
                        break;

                    case ConsoleKey.D2:
                        games.EditGame();
                        UI.PrintGameMenu();
                        break;

                    case ConsoleKey.D3:
                        games.RemoveGame();
                        UI.PrintGameMenu();
                        break;

                    case ConsoleKey.D4:
                        games.PrintGameList();
                        UI.PrintGameMenu();
                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;
                        
                }
            }
        }

        public void MovieSwitch()
        {
            var movies = new MoviesController();
            var loop = true;

            while (loop)
            {
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        movies.CreateMovie();
                        UI.PrintMovieMenu();
                        break;

                    case ConsoleKey.D2:
                        movies.EditMovie();
                        UI.PrintMovieMenu();
                        break;

                    case ConsoleKey.D3:
                        movies.RemoveMovie();
                        UI.PrintMovieMenu();
                        break;

                    case ConsoleKey.D4:
                        movies.PrintMovieList();
                        UI.PrintMovieMenu();
                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;

                }
            }
        }
    }
}
