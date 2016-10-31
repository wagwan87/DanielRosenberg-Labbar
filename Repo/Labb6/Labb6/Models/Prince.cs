using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    class Prince : IEnvironment, INonPlayerCharacter
    {
        public void Observe()
        {
            Console.WriteLine("The young prince is playing whith what looks as very expensive marbles");
        }

        public void Speech()
        {
            Console.WriteLine("Please help me find my mom! By the way a saw a beautiful horse in the stables, did you see it?");
        }
    }
}
