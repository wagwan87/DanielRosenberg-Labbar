﻿using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.DataStores.Repositories
{
    interface IRepository
    {
        Game[] GetGames();
        void AddGame(Game newGame);
        void RemoveGame(Game game);

        Movie[] GetMovies();
        void AddMovie(Movie newMovie);
        void RemoveMovie(Movie movie);
    }
}
