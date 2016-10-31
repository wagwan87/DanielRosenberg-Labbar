using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    class StableMaster : IEnvironment, INonPlayerCharacter
    {
        public void Observe()
        {
            Console.WriteLine("He looks really clean for a guy who works in a stable all day.");
        }

        public void Speech()
        {
            Console.WriteLine("You should talk to the king or the guards instead, I have nothing to say to you.");
        }
    }
}
