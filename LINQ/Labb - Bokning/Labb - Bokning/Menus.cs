using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class Menus
    {
        public static List<Booking> bookinglist = new List<Booking>();

        public static void DrawMainMenu()
        {

            Console.WriteLine("1 - Movie");
            Console.WriteLine("2 - Concert");
            Console.WriteLine("3 - Festival");
            Console.WriteLine("4 - Show your bookings");
            Console.WriteLine("5 - Exit");
        }

        public static void DrawMovieMenu()
        {
            Console.WriteLine("Choose a number corresponding to the movie you want to book or show info:");
            Console.WriteLine("1 - Guardians of the galaxy vol 2");
            Console.WriteLine("2 - Star Wars: Rogue One");
            Console.WriteLine("3 - Dr. Strange");
            Console.WriteLine("4 - Show info");
            Console.WriteLine("5 - Return");
        }

        public static void DrawConcertMenu()
        {
            Console.WriteLine("Choose a number corresponding to the concert you want to book or show info:");
            Console.WriteLine("1 - Rise Against");
            Console.WriteLine("2 - Nero");
            Console.WriteLine("3 - Xzibit");
            Console.WriteLine("4 - Show info");
            Console.WriteLine("5 - Return");
        }

        public static void DrawFestivalMenu()
        {
            Console.WriteLine("Choose a number corresponding to the festival you want to book or show info:");
            Console.WriteLine("1 - Pukkelpop");
            Console.WriteLine("2 - Roskilde");
            Console.WriteLine("3 - Emmaboda");
            Console.WriteLine("4 - Show info");
            Console.WriteLine("5 - Return");
        }

        public static Booking MovieBookingMenu(MovieManager inputMovieManager, string inputPersonName)
        {

            while (true)
            {
                int input;
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputMovieManager.Movies.ElementAt(0));
                        

                    case 2:
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputMovieManager.Movies.ElementAt(1));

                    case 3:
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputMovieManager.Movies.ElementAt(2));

                    case 4:
                        inputMovieManager.PrintMovies();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 5:
                        
                        break;

                    default:
                        return new Booking(new Person(),new Movie());
                        
                }
            }
        }

        public static Booking ConcertBookingMenu(ConcertManager inputConcertManager, string inputPersonName)
        {
            bool concertLoop = true;


            while (true)
            {
                int input;
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputConcertManager.Concerts.ElementAt(0));

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputConcertManager.Concerts.ElementAt(1));
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputConcertManager.Concerts.ElementAt(2));

                    case 4:
                        inputConcertManager.PrintConcerts();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 5:
                        concertLoop = false;
                        break;

                    default:
                        Menus.DrawConcertMenu();
                        break;
                }
            }
        }

        public static Booking FestivalBookingMenu(FestivalManager inputFestivalManager, string inputPersonName)
        {
            bool festivalLoop = true;


            while (true)
            {
                int input;
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Booking complete!");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputFestivalManager.Festivals.ElementAt(0));

                    case 2:
                        Console.WriteLine("Booking complete");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputFestivalManager.Festivals.ElementAt(1));
                    case 3:
                        Console.WriteLine("Booking complete");
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        DrawMainMenu();
                        return new Booking(new Person(inputPersonName), inputFestivalManager.Festivals.ElementAt(2));

                    case 4:
                        inputFestivalManager.PrintFestivals();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case 5:
                        festivalLoop = false;
                        break;

                    default:
                        Menus.DrawConcertMenu();
                        break;
                }
            }
        }
 
    }
}
