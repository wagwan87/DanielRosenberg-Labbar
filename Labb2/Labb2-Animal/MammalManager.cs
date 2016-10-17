using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    class MammalManager
    {
        public List<Lion> Lions { get; set; }
        public List<Mouse> Mice { get; set; }

        public MammalManager()
        {
            Lions = new List<Lion>()
            {
             new Lion { Speed = 40, PrideSize = 9, ColourOfFur = "Brown", Diet = "Antilope", NumberOfBabies = 3,
                      Age = 7, Weight = 290, Species = "Transvaal Lion"  },
              new Lion { Speed = 30, PrideSize = 11, ColourOfFur = "Yellow", Diet = "Zebras", NumberOfBabies = 2,
                      Age = 12, Weight = 250, Species = "Persian Lion"  } };

                { 
            Mice = new List<Mouse>()
            {
            new Mouse { Country = "Columbia", LengthOfTail = 6, ColourOfFur = "Grey", Diet = "Grass", NumberOfBabies = 10,
                        Age = 4, Weight = 1, Species = "Chinchilla" },
            new Mouse { Country = "Sweden", LengthOfTail = 4, ColourOfFur = "Brown", Diet = "Everything", NumberOfBabies = 12,
                        Age = 2, Weight = 0, Species = "House mouse"}

            };
        }

        }

        public void AddLion()
        {
            Lion newLion = new Lion();

            Console.Write("Speed: ");
            newLion.Speed = int.Parse(Console.ReadLine());

            Console.Write("Size of pride: ");
            newLion.PrideSize = int.Parse(Console.ReadLine());

            Console.Write("Colour of fur: ");
            newLion.ColourOfFur = Console.ReadLine();

            Console.Write("Diet: ");
            newLion.Diet = Console.ReadLine();

            Console.Write("Number of babies: ");
            newLion.NumberOfBabies = int.Parse(Console.ReadLine());

            Console.Write("Age: ");
            newLion.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newLion.Weight = int.Parse(Console.ReadLine());

            Console.Write("Species: ");
            newLion.Species = Console.ReadLine();

            Lions.Add(newLion);
        }

        public void RemoveLion()
        {  //Kanske fel
            for (int i = 1; i <= Lions.Count; i++)
            { Console.WriteLine("{0}. {1}", i, Lions[i - 1].Species); }

            Console.Write("Choose one: ");
            int choice = int.Parse(Console.ReadLine());

            Lions.RemoveAt(choice - 1);
        }

        public void PrintLions()
        {
            foreach (var lion in Lions)
            {
                Console.WriteLine("Speed: {0}, Size of pride: {1}, Colour of fur: {2}, Diet: {3}, Number of babies: {4}, Age: {5}, Weight: {6}, Species: {7}",
                    lion.Speed, lion.PrideSize, lion.ColourOfFur, lion.Diet, lion.NumberOfBabies, lion.Age, lion.Weight, lion.Species);
            }
        }




        public void AddMouse()
        {
            Mouse newMouse = new Mouse();

            Console.Write("Country: ");
            newMouse.Country = Console.ReadLine();

            Console.Write("Length of tail: ");
            newMouse.LengthOfTail = int.Parse(Console.ReadLine());

            Console.Write("Colour of fur: ");
            newMouse.ColourOfFur = Console.ReadLine();

            Console.Write("Diet: ");
            newMouse.Diet = Console.ReadLine();

            Console.Write("Number of babies: ");
            newMouse.NumberOfBabies = int.Parse(Console.ReadLine());

            Console.Write("Age: ");
            newMouse.Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            newMouse.Weight = int.Parse(Console.ReadLine());

            Console.Write("Species: ");
            newMouse.Species = Console.ReadLine();

            Mice.Add(newMouse);
        }

        public void RemoveMouse()
        {  //Kanske fel
            for (int i = 1; i <= Mice.Count; i++)
            { Console.WriteLine("{0}. {1}", i, Mice[i - 1].Species); }

            Console.Write("Choose one: ");
            int choice = int.Parse(Console.ReadLine());

            Mice.RemoveAt(choice - 1);
        }

        public void PrintMouse()
        {
            foreach (var mouse in Mice)
            {
                Console.WriteLine("Country: {0}, Length of tail: {1}, Colour of fur: {2}, Diet: {3}, Number of babies: {4}, Age: {5}, Weight: {6}, Species: {7}",
                    mouse.Country, mouse.LengthOfTail, mouse.ColourOfFur, mouse.Diet, mouse.NumberOfBabies, mouse.Age, mouse.Weight, mouse.Species);
            }
        }
    }
}
