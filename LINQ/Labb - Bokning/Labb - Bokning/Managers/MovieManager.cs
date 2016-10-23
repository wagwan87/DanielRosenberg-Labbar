using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class MovieManager
    {
        public List<Movie> Movies { get; set; }

        public MovieManager()
        {
            Movies = new List<Movie>()
          {
              new Movie (10, "Guardians of the galaxy vol 2", 13, "Chris Pratt" ),
              new Movie (12, "Star Wars: Rouge One", 15, "Jar Jar Binks" ),
              new Movie (8, "Dr. Strange", 15, "Benedict Cumberbatch" )
            };
        }

        public void PrintMovies()
        {
            foreach(var movie in Movies)
            {
                Console.WriteLine("The movie costs: {0}, The name is: {1}, You have to be at least: {2}, And the lead actor is: {3}",
                    movie.Price, movie.Name, movie.AgeRating, movie.LeadActor);
            }
        }
    }
}
