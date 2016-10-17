using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    class Runtime
    {
        AmphibiaManager amphibiamanager = new AmphibiaManager();
        ReptileManager reptilemanager = new ReptileManager();
        MammalManager mammalmanager = new MammalManager();

        public void Start()
        {

            bool loop = true;
            do
            {
                Menus.StartMenu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Menus.ReptileMenu();
                        ReptileSwitchMenu();
                        AlligatorSwitchMenu();

                        break;

                    case 2:
                        Menus.AmphibiaMenu();
                        AmphibiaSwitchMenu();
                        FrogSwitchMenu();
                        ToadSwitchMenu();

                        break;

                    case 3:
                        Menus.MammalMenu();
                        MammalSwitchMenu();
                        LionSwitchMenu();
                        MouseSwitchMenu();

                        break;

                    case 4: loop = false;

                        break;

                    default:
                        Console.WriteLine("Invalid input");

                        break;
                }



            } while (loop == true);
        }

        public void ReptileSwitchMenu()
        {
            bool continueReptileLoop = true;
            do
            {
                int secondInput = int.Parse(Console.ReadLine());
                switch (secondInput)
                {
                    case 1:

                        AlligatorSwitchMenu();
                        break;
                    case 2:
                        LizardSwitchMenu();
                        break;

                    default:
                        Menus.StartMenu();
                        break;
                }
            } while (continueReptileLoop == true);


        }

        public void AlligatorSwitchMenu()
        {

            bool continueAlligatorLoop = true;
            do
            {
                Menus.AlligatorMenu();

                int thirdInput = int.Parse(Console.ReadLine());
                switch (thirdInput)
                {
                    case 1:
                        reptilemanager.PrintAlligators();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        reptilemanager.AddAlligator();
                        break;
                    case 3:
                        reptilemanager.RemoveAlligator();
                        break;
                    case 4:
                        Menus.StartMenu();
                        Console.ReadLine();
                        break;
                    default:
                        AlligatorSwitchMenu();
                        break;
                }
            } while (continueAlligatorLoop == true);
        }

        public void LizardSwitchMenu()
        {

            bool continueLizardLoop = true;
            do
            {
                Menus.LizardMenu();

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        reptilemanager.PrintLizards();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        reptilemanager.AddLizard();
                        break;
                    case 3:
                        reptilemanager.RemoveLizard();
                        break;
                    case 4:
                        Menus.StartMenu();
                        Console.ReadLine();
                        break;
                    default:
                        LizardSwitchMenu();
                        break;
                }
            } while (continueLizardLoop == true);

        }
        public void AmphibiaSwitchMenu()
        {
            bool continueAmphibiaLoop = true;
            do
            {
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:

                        FrogSwitchMenu();
                        break;
                    case 2:
                        ToadSwitchMenu();
                        break;

                    default:
                        Menus.StartMenu();
                        break;
                }
            } while (continueAmphibiaLoop == true);


        }
        public void FrogSwitchMenu()
        {

            bool continueFrogLoop = true;
            do
            {
                Menus.FrogMenu();

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        amphibiamanager.PrintFrogs();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        amphibiamanager.AddFrog();
                        break;
                    case 3:
                        amphibiamanager.RemoveFrog();
                        break;
                    case 4:
                        Menus.StartMenu();
                        Console.ReadLine();
                        break;
                    default:
                        AmphibiaSwitchMenu();
                        break;
                }
            } while (continueFrogLoop == true);

        }


        public void ToadSwitchMenu()
        {

            bool continueToadLoop = true;
            do
            {
                Menus.ToadMenu();

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        amphibiamanager.PrintToads();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        amphibiamanager.AddToad();
                        break;
                    case 3:
                        amphibiamanager.RemoveToad();
                        break;
                    case 4:
                        Menus.StartMenu();
                        Console.ReadLine();
                        break;
                    default:
                        AmphibiaSwitchMenu();
                        break;
                }
            } while (continueToadLoop == true);
        }

        public void MammalSwitchMenu()
        {
            bool continueMammalLoop = true;
            do
            {
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:

                        LionSwitchMenu();
                        break;
                    case 2:
                        MouseSwitchMenu();
                        break;

                    default:
                        Menus.StartMenu();
                        break;
                }
            } while (continueMammalLoop == true);
        }
        public void LionSwitchMenu()
        {

            bool continueLionLoop = true;
            do
            {
                Menus.LionMenu();

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        mammalmanager.PrintLions();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        mammalmanager.AddLion();
                        break;
                    case 3:
                        mammalmanager.RemoveLion();
                        break;
                    case 4:
                        Menus.StartMenu();
                        Console.ReadLine();
                        break;
                    default:
                        MammalSwitchMenu();
                        break;
                }
            } while (continueLionLoop == true);
        }

        public void MouseSwitchMenu()
        {

            bool continueMouseLoop = true;
            do
            {
                Menus.MouseMenu();

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        mammalmanager.PrintMouse();
                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        mammalmanager.AddMouse();
                        break;
                    case 3:
                        mammalmanager.RemoveMouse();
                        break;
                    case 4:
                        Menus.StartMenu();
                        Console.ReadLine();
                        break;
                    default:
                        MammalSwitchMenu();
                        break;
                }
            } while (continueMouseLoop == true);
        }

        public void EndProgram()
        {
            Environment.Exit(0);
        }
    }
}



