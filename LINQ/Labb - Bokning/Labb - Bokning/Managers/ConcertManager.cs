using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class ConcertManager
    {
        public List<Concert> Concerts { get; set; }

        public ConcertManager()
        {
            Concerts = new List<Concert>()
          {
             new Concert (20, "Rise Against", 2, "Melodic Hardcore" ),
             new Concert (25, "Nero", 2, "Dubstep" ),
             new Concert (20, "Xzibit", 1, "Hiphop")
            };
        }

        public void PrintConcerts()
        {
            foreach (var concert in Concerts)
            {
                Console.WriteLine("The concert costs: {0}, The name is: {1}, The length is: {2}, And the genre is: {3}",
                    concert.Price, concert.Name, concert.Length, concert.Genre);
            }
        }
    }
}
