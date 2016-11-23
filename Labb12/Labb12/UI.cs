using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class UI
    {
        public static void DrawMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Select one movie by name");
            Console.WriteLine("2 - Get all movies from a single category");
            Console.WriteLine("3 - Get all movies that's under 2h");
            Console.WriteLine("4 - Print all movies in a string array");
            Console.WriteLine("5 - Store a movie in a string variable");
            Console.WriteLine("6 - In-depth search");
            Console.WriteLine("7 - Exit");
        }
    }
}
