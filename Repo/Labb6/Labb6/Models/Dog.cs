using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
   public class Dog : INonPlayerCharacter, IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("It's a rugged dog, perhaps a stray?");
        }

        public void Speech()
        {
            Console.WriteLine("Help! I'm trapped in this body, it's me the queen!");
        }
    }
}
