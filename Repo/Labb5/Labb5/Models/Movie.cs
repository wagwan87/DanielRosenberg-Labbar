using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class Movie
    {
        public enum MovieGenreType
        {
            Horror = 1,
            Comedy,
            ScienceFiction,
            Documentary,
            Action,
        }

        public MovieGenreType MovieGenre { get; set; }
        public string MovieName { get; set; }
    }
}
