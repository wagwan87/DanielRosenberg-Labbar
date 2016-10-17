using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    class AmphibiaManager
    {
        public List<Frog> Frogs { get; set; }
        public List<Toad> Toads { get; set; }

        public AmphibiaManager()
        {
            Frogs = new List<Frog>()
            {
              new Frog { JumpLength = 2, Pattern ="Black circles", ColourOfSkin = "Green", Habitat = "Swamps", NumberOfBabies = 6500,
                        Age = 3, Weight = 0, Species = "Northern Leopard Frog"},
               new Frog { JumpLength = 3, Pattern ="Black stripes", ColourOfSkin = "Brown", Habitat = "Ponds", NumberOfBabies = 2000,
                        Age = 1, Weight = 0, Species = "Striped Marsh Frog"} };
            { 

            Toads = new List<Toad>()
            {
              new Toad { ColourOfBelly = "Beige", LengthOfTongue = 8, ColourOfSkin = "Brown", Habitat = "Humid", NumberOfBabies = 4000,
                        Age = 9, Weight = 1, Species = "American Toad" },
              new Toad { ColourOfBelly = "Brown", LengthOfTongue = 4, ColourOfSkin = "Green", Habitat = "High altitude", NumberOfBabies = 7000,
                        Age = 6, Weight = 1, Species = "Boreal Toad"}

            };
        }

    }

    public void AddFrog()
    {
        Frog newFrog = new Frog();

        Console.Write("Jumplength: ");
        newFrog.JumpLength = int.Parse(Console.ReadLine());

        Console.Write("Pattern: ");
        newFrog.Pattern = Console.ReadLine();

        Console.Write("Colour of skin: ");
        newFrog.ColourOfSkin = Console.ReadLine();

        Console.Write("Habitat: ");
        newFrog.Habitat = Console.ReadLine();

        Console.Write("Number of babies: ");
        newFrog.NumberOfBabies = int.Parse(Console.ReadLine());

        Console.Write("Age: ");
        newFrog.Age = int.Parse(Console.ReadLine());

        Console.Write("Weight: ");
        newFrog.Weight = int.Parse(Console.ReadLine());

        Console.Write("Species: ");
        newFrog.Species = Console.ReadLine();

        Frogs.Add(newFrog);
    }

    public void RemoveFrog()
    {  //Kanske fel
        for (int i = 1; i <= Frogs.Count; i++)
        { Console.WriteLine("{0}. {1}", i, Frogs[i - 1].Species); }

        Console.Write("Choose one: ");
        int choice = int.Parse(Console.ReadLine());

        Frogs.RemoveAt(choice - 1);
    }

    public void PrintFrogs()
    {
        foreach (var frog in Frogs)
        {
                Console.WriteLine("Jumplength: {0}, Pattern: {1}, Colour of skin: {2}, Habitat: {3}, Number of babies: {4}, Age: {5}, Weight: {6}, Species: {7}, Move: {8}",
                    frog.JumpLength, frog.Pattern, frog.ColourOfSkin, frog.Habitat, frog.NumberOfBabies, frog.Age, frog.Weight, frog.Species, frog.Move());
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }




    public void AddToad()
    {
        Toad newToad = new Toad();

        Console.Write("Colour of belly: ");
        newToad.ColourOfBelly = Console.ReadLine();

        Console.Write("Length of tongue: ");
        newToad.LengthOfTongue = int.Parse(Console.ReadLine());

        Console.Write("Colour of skin: ");
        newToad.ColourOfSkin = Console.ReadLine();

        Console.Write("Habitat: ");
        newToad.Habitat = Console.ReadLine();

        Console.Write("Number of babies: ");
        newToad.NumberOfBabies = int.Parse(Console.ReadLine());

        Console.Write("Age: ");
        newToad.Age = int.Parse(Console.ReadLine());

        Console.Write("Weight: ");
        newToad.Weight = int.Parse(Console.ReadLine());

        Console.Write("Species: ");
        newToad.Species = Console.ReadLine();

        Toads.Add(newToad);
    }

    public void RemoveToad()
    {  //Kanske fel
        for (int i = 1; i <= Toads.Count; i++)
        { Console.WriteLine("{0}. {1}", i, Toads[i - 1].Species); }

        Console.Write("Choose one: ");
        int choice = int.Parse(Console.ReadLine());

        Toads.RemoveAt(choice - 1);
    }

    public void PrintToads()
    {
        foreach (var toad in Toads)
        {
            Console.WriteLine("Colour of belly: {0}, Length of tongue: {1}, Colour of skin: {2}, Habitat: {3}, Number of babies: {4}, Age: {5}, Weight: {6}, Species: {7}",
                toad.ColourOfBelly, toad.LengthOfTongue, toad.ColourOfSkin, toad.Habitat, toad.NumberOfBabies, toad.Age, toad.Weight, toad.Species);
        }
    }
}
}
