using Labb7.ProductCategories;
using Labb7.ProductManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class UI
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello and welcome! Please choose a category");
            Console.WriteLine("1 - Cellphones");
            Console.WriteLine("2 - Computers");
            Console.WriteLine("3 - Television");
            Console.WriteLine("4 - Exit");
        }
    }
}
