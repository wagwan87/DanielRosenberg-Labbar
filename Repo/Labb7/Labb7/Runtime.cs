using Labb7.ProductCategories;
using Labb7.ProductManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class Runtime
    {
        CellphoneManager cellphonemanager = new CellphoneManager();
        ComputerManager computermanager = new ComputerManager();
        TelevisionManager televisionmanager = new TelevisionManager();

        public void Start()
        {
            var loop = true;
            while (loop)
            {
                UI.MainMenu();

                var input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        cellphonemanager.PrintCellphones();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        computermanager.PrintComputers();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        televisionmanager.PrintTelevisions();
                        Console.ReadKey(true);
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
