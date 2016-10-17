using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    class Menus
    {
        public static void StartMenu()
        {
            Console.WriteLine("Please choose one");
            Console.WriteLine("1 - Reptiles");
            Console.WriteLine("2 - Amphibians");
            Console.WriteLine("3 - Mammals");
            Console.WriteLine("4 - Exit");
        }

        public static void AmphibiaMenu()
        {
            Console.WriteLine("1 - Frogs");
            Console.WriteLine("2 - Toads");
        }

        public static void ReptileMenu()
        {
            Console.WriteLine("1 - Alligators");
            Console.WriteLine("2 - Lizards");
        }

        public static void MammalMenu()
        {
            Console.WriteLine("1 - Lion");
            Console.WriteLine("2 - Mouse");
        }

        public static void AlligatorMenu()
        {
            Console.WriteLine("1 - Show Alligators");
            Console.WriteLine("2 - Add Alligators");
            Console.WriteLine("3 - Remove Alligators");
            Console.WriteLine("4 - Return");
        }

        public static void LizardMenu()
        {
            Console.WriteLine("1 - Show Lizards");
            Console.WriteLine("2 - Add Lizards");
            Console.WriteLine("3 - Remove Lizards");
            Console.WriteLine("4 - Return");
        }

        public static void FrogMenu()
        {
            Console.WriteLine("1 - Show Frogs");
            Console.WriteLine("2 - Add Frogs");
            Console.WriteLine("3 - Remove Frogs");
            Console.WriteLine("4 - Return");
        }

        public static void ToadMenu()
        {
            Console.WriteLine("1 - Show Toads");
            Console.WriteLine("2 - Add Toads");
            Console.WriteLine("3 - Remove Toads");
            Console.WriteLine("4 - Return");
        }

        public static void LionMenu()
        {
            Console.WriteLine("1 - Show Lions");
            Console.WriteLine("2 - Add Lions");
            Console.WriteLine("3 - Remove Lions");
            Console.WriteLine("4 - Return");
        }

        public static void MouseMenu()
        {
            Console.WriteLine("1 - Show Mice");
            Console.WriteLine("2 - Add Mouse");
            Console.WriteLine("3 - Remove Mouse");
            Console.WriteLine("4 - Return");
        }
    }
}
