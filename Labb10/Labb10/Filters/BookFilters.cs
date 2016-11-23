using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10.Filters
{
    class BookFilters
    {
        public static bool IsShortstory(Book book)
        {
            return book.Pages < 350;
        }

        public static bool IsNovel(Book book)
        {
            return book.Pages > 350;
        }

        public static bool IsGenreHorror(Book book)
        {
            return book.Genre == "Horror";
        }

        public static bool IsGenreCrime(Book book)
        {
            return book.Genre == "Crime";
        }

        public static bool IsGenreDrama(Book book)
        {
            return book.Genre == "Drama";
        }

        public static bool IsGenreCookbook(Book book)
        {
            return book.Genre == "Cookbook";
        }

        public static bool IsGenreFantasy(Book book)
        {
            return book.Genre == "Fantasy";
        }

        public static bool IsGenreThriller(Book book)
        {
            return book.Genre == "Thriller";
        }

        public static bool IsGenreAutobiography(Book book)
        {
            return book.Genre == "Autobiography";
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price > 49;
        }

        public static bool IsCheap(Book book)
        {
            return book.Price < 49;
        }

        public static bool NameThatStartsWithT(Book book)
        {
            return book.Title[0] == 'T';
        }
    }
}
