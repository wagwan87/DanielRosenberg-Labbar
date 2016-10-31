using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    class StableBoy : IEnvironment, INonPlayerCharacter
    {
        public void Observe()
        {
            Console.WriteLine("The stable boy looks tired and is cleaning up after the horses");
        }

        public void Speech()
        {
            Console.WriteLine("Hello! Maybe you should speak with the stablemaster, I'm quite busy");
        }
    }
}
