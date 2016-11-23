using Labb13.Managers;
using Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13
{
    class Runtime
    {
        DinosaurManager dinosaurManager { get; set; }

        public void Start()
        {
            DinosaurManager dinosaurManager = new DinosaurManager();
            dinosaurManager.WrongInput += (message) => { Console.WriteLine("Wrong input" + message); };

            bool loop = true;

            do
            {
                Console.Clear();

                UI.DrawMainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        dinosaurManager.PrintDinosaurs();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        dinosaurManager.AddDinosaur();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        dinosaurManager.DinosaurStartsWithLetter();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D4:
                        dinosaurManager.GetDinosaurUnderOneTon();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D5:
                        dinosaurManager.GetDinosaursOver5Meters();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D6:
                        Environment.Exit(0);
                        break;

                }

            } while (loop);
        }

    }
}
