using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    class ReptileManager
    {
        public List<Alligator> Alligators { get; set; }
        public List<Lizard> Lizards { get; set; }

        public ReptileManager()
        {

            Alligators = new List<Alligator>()
            {
                new Alligator { NumberOfteeth = 80, CountryOfOrigin = "China", Age = 39, Weight = 400,
                                ColourOfScales = "Green", Habitat = "Salt water", Species = "Yangtze alligator", NumberOfBabies = 7 },
                new Alligator {NumberOfteeth = 90, CountryOfOrigin = "USA", Age = 10, Weight = 200,
                                ColourOfScales = "Brown", Habitat = "Salt water", Species = "Florida alligator", NumberOfBabies = 8 } };
                 
        {
            Lizards = new List<Lizard>()
            {
               new Lizard { Continent = "South America", LengthOfClaws = 5, ColourOfScales = "Grey", Habitat = "Dry land", NumberOfBabies = 10,
              Age = 14, Weight = 60, Species = "Comodo Dragon" },
                new Lizard { Continent = "Central America", LengthOfClaws = 2, ColourOfScales = "Green", Habitat = "Rainforest", NumberOfBabies = 12,
              Age = 8, Weight = 10, Species = "Green Iguana" }
            };
        
    }
        }

        public void AddAlligator()
        {
            Alligator newAlligator = new Alligator();

            Console.Write("Number of teeth: ");
            newAlligator.NumberOfteeth = int.Parse(Console.ReadLine());

            Console.Write("Country of origin: ");
            newAlligator.CountryOfOrigin = Console.ReadLine();

            Console.Write("Age: ");
            newAlligator.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newAlligator.Weight = int.Parse(Console.ReadLine());

            Console.Write("Colour of scale: ");
            newAlligator.ColourOfScales = Console.ReadLine();

            Console.Write("Habitat: ");
            newAlligator.Habitat = Console.ReadLine();

            Console.Write("Species: ");
            newAlligator.Species = Console.ReadLine();

            Console.Write("Number of babies: ");
            newAlligator.NumberOfBabies = int.Parse(Console.ReadLine());

            Alligators.Add(newAlligator);
        }

        public void RemoveAlligator()
        {  //Kanske fel
            for (int i = 1; i <= Alligators.Count; i++)
            { Console.WriteLine("{0}. {1}", i, Alligators[i - 1].Species); }

            Console.Write("Choose one: ");
            int choice = int.Parse(Console.ReadLine());

            Alligators.RemoveAt(choice - 1);
        }

        public void PrintAlligators()
        {
            foreach (var alligator in Alligators)
            {
                Console.WriteLine("Number of teeth: {0}, Country of origin: {1}, Age: {2}, Weight: {3}, Colour of Scale: {4}, Habitat: {5}, Species: {6}, Number of babies: {7}",
                    alligator.NumberOfteeth, alligator.CountryOfOrigin, alligator.Age, alligator.Weight, alligator.ColourOfScales, alligator.Habitat, alligator.Species, alligator.NumberOfBabies);
            }
        }

       

        public void AddLizard()
        {
            Lizard newLizard = new Lizard();

            Console.Write("Continent: ");
            newLizard.Continent = Console.ReadLine();

            Console.Write("Length of claws: ");
            newLizard.LengthOfClaws = int.Parse(Console.ReadLine());

            Console.Write("Colour of scales: ");
            newLizard.ColourOfScales = Console.ReadLine();

            Console.Write("Habitat: ");
            newLizard.Habitat = Console.ReadLine();

            Console.Write("Number of babies: ");
            newLizard.NumberOfBabies = int.Parse(Console.ReadLine());

            Console.Write("Age: ");
            newLizard.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newLizard.Weight = int.Parse(Console.ReadLine());

            Console.Write("Species: ");
            newLizard.Species = Console.ReadLine();

            Lizards.Add(newLizard);
        }

        public void RemoveLizard()
        {  //Kanske fel
            for (int i = 1; i <= Lizards.Count; i++)
            { Console.WriteLine("{0}. {1}", i, Lizards[i - 1].Species); }

            Console.Write("Choose one: ");
            int choice = int.Parse(Console.ReadLine());

            Lizards.RemoveAt(choice - 1);
        }

        public void PrintLizards()
        {
            foreach (var lizard in Lizards)
            {
                Console.WriteLine("Continent: {0}, Length of claws: {1}, Colour of scales: {2}, Habitat: {3}, Number of babies: {4}, Age: {5}, Weight: {6}, Species: {7}",
                    lizard.Continent, lizard.LengthOfClaws, lizard.ColourOfScales, lizard.Habitat, lizard.NumberOfBabies, lizard.Age, lizard.Weight, lizard.Species);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

}
