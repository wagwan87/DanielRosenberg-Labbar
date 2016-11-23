using Labb10.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter isNovelFilter = (BookFilters.IsNovel);
            BookFilter isShortStoryFilter = (BookFilters.IsShortstory);
            BookFilter isGenreHorrorFilter = (BookFilters.IsGenreHorror);
            BookFilter isGenreCrimeFilter = (BookFilters.IsGenreCrime);
            BookFilter isGenreFantasyFilter = (BookFilters.IsGenreFantasy);
            BookFilter isGenreDramaFilter = (BookFilters.IsGenreDrama);
            BookFilter isGenreCookbookFilter = (BookFilters.IsGenreCookbook);
            BookFilter isGenreAutobiographyFilter = (BookFilters.IsGenreAutobiography);
            BookFilter isExpensiveFilter = (BookFilters.IsExpensive);
            BookFilter isCheapFilter = (BookFilters.IsCheap);

            Console.WriteLine("Novels: ");
            manager.PrintWhere(isNovelFilter);

            Console.WriteLine("\nShortstory: ");
            manager.PrintWhere(isShortStoryFilter);

            Console.WriteLine("\nHorror: ");
            manager.PrintWhere(isGenreHorrorFilter);

            Console.WriteLine("\nCrime: ");
            manager.PrintWhere(isGenreCrimeFilter);

            Console.WriteLine("\nFantasy: ");
            manager.PrintWhere(isGenreFantasyFilter);

            Console.WriteLine("\nDrama: ");
            manager.PrintWhere(isGenreDramaFilter);

            Console.WriteLine("\nCookbook: ");
            manager.PrintWhere(isGenreCookbookFilter);

            Console.WriteLine("\nAutobiography: ");
            manager.PrintWhere(isGenreAutobiographyFilter);

            Console.WriteLine("\nExpensive: ");
            manager.PrintWhere(isExpensiveFilter);

            Console.WriteLine("\nCheap: ");
            manager.PrintWhere(isCheapFilter);

        }
    }
}
