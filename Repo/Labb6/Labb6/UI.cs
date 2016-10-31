using Labb6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    public class UI
    {


        public static void WelcomeScreen()
        {
            Console.WriteLine("Hello and welcome to the kingdom of Consolica. \nThe king Consolicon has lost his queen, they believe that she is still around but in another form. \nYou are our last hope, please help.");
            Console.ReadKey(true);
        }

        public static void EnvironmentMenu()
        {


            var loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Where would you like to go?");
                Console.WriteLine("1 - Throneroom");
                Console.WriteLine("2 - Courtyard");
                Console.WriteLine("3 - Stables");
                Console.WriteLine("4 - Dungeon");
                Console.WriteLine("5 - Exit game");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        ThroneroomSection();
                        break;

                    case 2:
                        CourtyardSection();
                        break;

                    case 3:
                        StableSection();
                        break;

                    case 4:
                        DungeonSection();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void ThroneroomSection()
        {
            Throneroom throneroom = new Throneroom();

            var loop = true;


            while (loop)
            {
                Console.Clear();
                Console.WriteLine("You are in the Throneroom, what do you do?");

                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Interact with guard");
                Console.WriteLine("3 - Interact with king");
                Console.WriteLine("4 - Leave");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        throneroom.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        GuardMenu();
                        break;

                    case 3:
                        KingMenu();
                        break;
                }
            }
        }

        public static void GuardMenu()
        {
            Guard guard = new Guard();
            var loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("The guard looks impatient");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak to");
                Console.WriteLine("3 - Leave");

                var input = int.Parse(Console.ReadLine());



                switch (input)
                {
                    case 1:
                        guard.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        guard.Speech();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        loop = false;
                        break;
                }
            }
        }
        public static void KingMenu()
        {

            King king = new King();

            var loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("You stand before the king, watch what you say.");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak");
                Console.WriteLine("3 - Try to solve his problem");
                Console.WriteLine("4 - Leave");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        king.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        king.Speech();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        KingProblemMenu();
                        break;
                }
            }
        }

        public static void KingProblemMenu()
        {
            var loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("So you think you know who the queen is? I must warn you, if you don't answer correctly I will have your head!");
                Console.WriteLine("1 - The guard");
                Console.WriteLine("2 - The stableboy");
                Console.WriteLine("3 - The stablemaster");
                Console.WriteLine("4 - The dog");
                Console.WriteLine("5 - The horse");
                Console.WriteLine("6 - The king himself");
                Console.WriteLine("7 - The prince");
                Console.WriteLine("8 - The prisoner");
                Console.WriteLine("9 - I still need som time to think");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 2:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 3:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 4:
                        Console.WriteLine("Hmm, that doesn't sound right, hold on let me send a guard to check your theory...... Splendid! You found her, now it's just the small matter of turning her back, oh well that's an adventure for another day. \nAs thanks you will get a big sack of gold!");
                        Environment.Exit(0);
                        break;

                    case 5:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 6:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 7:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 8:
                        Console.WriteLine("Guards! Seize this man and execute him in the morning");
                        Environment.Exit(0);
                        break;

                    case 9:
                        loop = false;
                        break;
                }
            }
        }

        public static void CourtyardSection()
        {
            Courtyard courtyard = new Courtyard();

            var loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("You're in the courtyard, what do you do?");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Interact with guard");
                Console.WriteLine("3 - Interact with prince");
                Console.WriteLine("4 - Leave");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        courtyard.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        GuardMenu();
                        break;

                    case 3:
                        PrinceMenu();
                        break;

                    case 4:
                        loop = false;
                        break;
                }
            }

        }

        public static void PrinceMenu()
        {
            Prince prince = new Prince();

            var loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("The prince hasn't noticed you");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak to");
                Console.WriteLine("3 - Leave");

                var input = int.Parse(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        prince.Observe();
                        break;

                    case 2:
                        prince.Speech();
                        break;

                    case 3:
                        loop = false;
                        break;
                }
            }
        }

        public static void StableSection()
        {
            Stables stables = new Stables();

            var loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("You're in the stables, what do you do?");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Interact with guard");
                Console.WriteLine("3 - Interact with stableboy");
                Console.WriteLine("4 - Interact with stablemaster");
                Console.WriteLine("5 - Leave");

                var input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        stables.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        GuardMenu();
                        break;

                    case 3:
                        StableBoyMenu();
                        break;

                    case 4:
                        StableMasterMenu();
                        break;

                    case 5:
                        loop = false;
                        break;
                }
            }
        }

        public static void StableBoyMenu()
        {
            StableBoy stableboy = new StableBoy();

            var loop = true;

            while(loop)
            {
                Console.Clear();
                Console.WriteLine("The stableboy stops working and is looking at you.");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak to");
                Console.WriteLine("3 - Leave");

                var input = int.Parse(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        stableboy.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        stableboy.Speech();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        loop = false;
                        break;
                }
            }
        }

        public static void StableMasterMenu()
        {
            StableMaster stablemaster = new StableMaster();

            var loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("The stablemaster looks anoyed");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak to");
                Console.WriteLine("3 - Leave");

                var input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        stablemaster.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        stablemaster.Speech();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        loop = false;
                        break;
                }
            }
        }
        
        public static void DungeonSection()
        {
            Dungeon dungeon = new Dungeon();

            var loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("You're in the dungeon, what do you do?");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Interact with prisoner");
                Console.WriteLine("3 - Interact with dog");
                Console.WriteLine("4 - Leave");

                var input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        dungeon.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        PrisonerMenu();
                            break;

                    case 3:
                        DogMenu();
                            break;

                    case 4:
                        loop = false;
                        break;
                }

            }
        }

        public static void PrisonerMenu()
        {
            Prisoner prisoner = new Prisoner();

            var loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("The prisoner looks at you without hope in his eyes");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak to");
                Console.WriteLine("3 - Leave");

                var input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        prisoner.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        prisoner.Speech();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        loop = false;
                        break;
                }
            }
        }

        public static void DogMenu()
        {
            Dog dog = new Dog();

            var loop = true;
            while(loop)
            {
                Console.Clear();
                Console.WriteLine("The dog just stands there waiting for you");
                Console.WriteLine("1 - Observe");
                Console.WriteLine("2 - Speak to");
                Console.WriteLine("3 - Leave");

                var input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        dog.Observe();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        dog.Speech();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        loop = false;
                        break;
                }
            }

        }
    }
}
