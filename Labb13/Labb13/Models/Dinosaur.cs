using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Models
{
   public class Dinosaur
    {
        public string Species { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string Weapon { get; set; }

        public static string DinosaurFormat1()
        {
            return String.Format("Species", "Height", "Weight, Weapon");
        }

        public string DinosaurFormat2()
        {
            return String.Format(Species, Height, Weight, Weapon);
        }
    }
}
