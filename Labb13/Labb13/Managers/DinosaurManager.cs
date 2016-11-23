using Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Managers
{
    class DinosaurManager
    {
       public List<Dinosaur> Dinosaurs { get; set; }
        public event NothingFound WrongInput;

        public DinosaurManager()
        {
            Dinosaurs = new List<Dinosaur>()
            {
                new Dinosaur {Species = "Triceratops", Height = 3, Weight = 1000 , Weapon = "Giant horns" },
                new Dinosaur {Species = "Velociraptor", Height = 2, Weight = 200 , Weapon = "Teeth and claws" },
                new Dinosaur {Species = "T-Rex", Height = 7, Weight = 3000, Weapon = "Teeth and size" },
                new Dinosaur {Species = "Stegosaurus", Height = 5, Weight = 2500 , Weapon = "Spiked tail" },
                new Dinosaur {Species = "Pterodactyl", Height = 2, Weight = 400, Weapon = "Beak and claws" },
                new Dinosaur {Species = "Brachiosaurus", Height = 15,Weight = 9000 , Weapon = "Tail and size" },
            };
        }

        public void PrintDinosaurs()
        {
            foreach(var dinosaur in Dinosaurs)
            {
                Console.WriteLine("Species: {0}, Height: {1}, Weight: {2}, Weapon: {3}",
                    dinosaur.Species, dinosaur.Height, dinosaur.Weight, dinosaur.Weapon);
            }
        }

        public void AddDinosaur()
        {
            Dinosaur newDinosaur = new Dinosaur();

            Console.Write("Species: ");
            string species = Console.ReadLine();
            if (!(species.Length < 2 || species.Length > 20))
                newDinosaur.Species = species;
            else
            {
                OnWrongInput(" the name of the species must be more than 2 letters and less than 20.");
                Console.WriteLine("Please start over");
                Console.ReadKey(true);
                return;
            }

            Console.Write("Height: ");
            newDinosaur.Height = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newDinosaur.Weight = int.Parse(Console.ReadLine());

            Console.Write("Weapons: ");
            newDinosaur.Weapon = Console.ReadLine();
            Dinosaurs.Add(newDinosaur);
        }

        public void DinosaurStartsWithLetter()
        {
            Console.Write("What is the first letter in the species? : ");

            string letter = Console.ReadLine();

            List<Dinosaur> dinosaurs = Dinosaurs.Where(dinosaur => String.Equals(dinosaur.Species[0], letter[0])).ToList();
            if (!(dinosaurs.Count == 0))
            {
                Console.WriteLine("Result:");

                foreach (var dinosaur in dinosaurs)
                {
                    Console.WriteLine(dinosaur.DinosaurFormat2());
                }
            }
            else
                Console.WriteLine("Sorry no dinosaurs matched your criteria.");

        }

        public void GetDinosaurUnderOneTon()
        {
            List<Dinosaur> dinosaurs = Dinosaurs.Where(dinosaur => dinosaur.Weight < 1000).ToList();

            Console.WriteLine(Dinosaur.DinosaurFormat1());

            foreach (var dinosuar in dinosaurs)
            {
                Console.WriteLine(dinosuar.DinosaurFormat2());
            }

        }

        public void GetDinosaursOver5Meters()
        {
            List<Dinosaur> dinosaurs = Dinosaurs.Where(dinosaur => dinosaur.Height >= 5).ToList();

            Console.WriteLine(Dinosaur.DinosaurFormat1());

            foreach (var dinosuar in dinosaurs)
            {
                Console.WriteLine(dinosuar.DinosaurFormat2());
            }
        }

        public void UserOptionFilter(Filter filter)
        {
            if (filter != null)
            {
                foreach (var dinosaur in Dinosaurs)
                {
                    if (filter(dinosaur))
                        Console.WriteLine(dinosaur.DinosaurFormat2());
                }
            }
            else
                Console.WriteLine("Nothing found.");
        }

        protected virtual void OnWrongInput(string message)
        {
            WrongInput?.Invoke(message);
        }
    }
}
