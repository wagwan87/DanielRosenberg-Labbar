using Labb14.Library;
using Labb14.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Runtime
    {
        public void Start()
        {
            Author authorOne = new Author() { Name = "H.P Lovecraft", Age = 126 };
            Author authorTwo = new Author() { Name = "Stephen King", Age = 69 };
            Author authorThree = new Author() { Name = "John Grisham", Age = 61 };
            Author authorFour = new Author() { Name = "Ernest Hemingway", Age = 117 };

            Book book = new Book() { Author = authorOne, Genre = "Horror", Title = "Dagon", Pages = 100, ReleaseDate = new DateTime(1919, 12, 24) };

            Magazine magazine = new Magazine() { Author = authorTwo, Title = "Famous", ReleaseDate = new DateTime(2016, 11, 30) };

            Paper paper = new Paper() { Author = authorThree, Title = "The New Yorker", ReleaseDate = new DateTime(2016, 11, 24) };


        }
    }
}
