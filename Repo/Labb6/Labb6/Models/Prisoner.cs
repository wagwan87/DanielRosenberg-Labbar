using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    class Prisoner : IEnvironment, INonPlayerCharacter
    {
        public void Observe()
        {
            Console.WriteLine("The prisoner looks pretty clean for a prisoner, maybe he hasn't been here long");
        }

        public void Speech()
        {
            Console.WriteLine("Oh, are you here to try and find the queen? Watch what you say, because if you get it wrong the king won't show you any mercy.");
        }
    }
}
