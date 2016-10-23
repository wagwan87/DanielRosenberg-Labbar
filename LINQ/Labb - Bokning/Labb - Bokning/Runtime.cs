using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class Runtime
    {
        public static List<Booking> bookinglist1 = new List<Booking>();
        public static List<Booking> bookinglist2 = new List<Booking>();
        public static List<Booking> bookinglist3 = new List<Booking>();

        public static MovieManager moviemanager = new MovieManager();
        public static ConcertManager concertmanager = new ConcertManager();
        public static FestivalManager festivalmanager = new FestivalManager();

        public void Start()
        {
            Console.WriteLine("Please enter your name: ");
            string inputUserName = Console.ReadLine();


            while (true)
            {
                Menus.DrawMainMenu();
                int input;
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {

                    case 1:
                        Console.Clear();
                        Menus.DrawMovieMenu();
                        bookinglist1.Add(Menus.MovieBookingMenu(Runtime.moviemanager, inputUserName));

                        break;

                    case 2:
                        Console.Clear();
                        Menus.DrawConcertMenu();
                        bookinglist2.Add(Menus.ConcertBookingMenu(concertmanager, inputUserName));

                        break;

                    case 3:
                        Console.Clear();
                        Menus.DrawFestivalMenu();
                        bookinglist3.Add(Menus.FestivalBookingMenu(festivalmanager, inputUserName));

                        break;

                    case 4:
                        Console.Clear();
                        List<Booking> listEventMovies = bookinglist1
                          .Where(Booking => String.Equals(Booking.Event.Type, "Movie"))
                         .Select(Booking => Booking).ToList();
                        foreach (var c in listEventMovies)
                        {
                            Console.WriteLine(String.Format("{0} \n{1}",c.Event.Name, c.Person.Name));
                        }

                        List<Booking> listEventsConcert = bookinglist2
                            .Where(Booking => String.Equals(Booking.Person.Name, inputUserName))
                           .Select(Booking => Booking).ToList();

                        foreach (var c in listEventsConcert)
                        {
                            Console.WriteLine(String.Format("{0} \n{1}",c.Event.Name, c.Person.Name));
                        }

                        List<Booking> listEventsFestivals = bookinglist3
                       .Where(Booking => String.Equals(Booking.Person.Name, inputUserName))
                       .Select(Booking => Booking).ToList();

                        foreach (var c in listEventsFestivals)
                        {
                            Console.WriteLine(String.Format("{0} \n{1}", c.Event.Name, c.Person.Name));
                        }

                        break;

                    case 5:
                        Environment.Exit(0);

                        break;

                    default:
                        Console.Clear();
                        Menus.DrawMainMenu();
                        break;
                }
            }
        }

    }


}

