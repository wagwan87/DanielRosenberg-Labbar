using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>
            {
                new Book {Title = "The Talisman", Genre = "Horror", Pages = 900, Price = 99.99 },
                new Book {Title = "Fear and lothing in Las Vegas", Genre = "Drama", Pages = 200, Price = 39.99 },
                new Book {Title = "Black dog", Genre = "Thriller", Pages = 400, Price = 49.99 },
                new Book {Title = "The anarchist cookbook", Genre = "Cookbook", Pages = 600, Price = 1.00 },
                new Book {Title = "Slash", Genre = "Autobiography", Pages = 450, Price = 59.99 },
                new Book {Title = "The lord of the rings", Genre = "Fantasy", Pages = 900, Price = 79.99 },
                new Book {Title = "The firm", Genre = "Crime", Pages = 600, Price = 79.99 },
                new Book {Title = "American psycho", Genre = "Horror", Pages = 500, Price = 49.99 },
                new Book {Title = "The alchemist", Genre = "Drama", Pages = 300, Price = 49.99 },

            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach(var book in Books)
            {
                if (filter(book))
                    Console.WriteLine(book.Title);
            }
        }

    }
}
