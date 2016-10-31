using Labb5.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Controllers
{
    class MoviesController
    {
        private IRepository repository = new ListRepository();

        public void CreateMovie()
        {
            var newMovie = UI.CreateMovie();
            repository.AddMovie(newMovie);
        }

        public void RemoveMovie()
        {
            var movies = repository.GetMovies();
            var index = UI.SelectMovie(repository.GetMovies()) - 1;
            repository.RemoveMovie(movies[index]);
        }

        public void EditMovie()
        {
            var movies = repository.GetMovies();
            UI.PrintMovieList(movies);
            int index = UI.SelectMovie(movies) - 1;
            UI.EditMovie(movies[index]);
        }

        public void PrintMovieList()
        {
            Console.Clear();
            UI.PrintMovieList(repository.GetMovies());
            Console.ReadKey(true);
        }
    }
}
