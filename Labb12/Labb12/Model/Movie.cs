using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12.Models
{
    class Movie
    {
        public string Title { get; set; }

        public Categories Category { get; set; }

        public int Length { get; set; }

        public enum Categories
        {
            Horror = 1,
            Fantasy,
            Drama,
            Thriller,
            Comedy
        }

        public static string MovieFormat1()
        {
            return String.Format("Title", "Length", "Category");
        }

        public string MovieFormat2()
        {
            return String.Format(Title, Length, Category);
        }
    }
}
