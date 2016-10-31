using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    public class Guard : INonPlayerCharacter, IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("A guard with a large sword and shiny armour");
        }

        public void Speech()
        {
            Console.WriteLine("Go bother someone else I'm busy, I saw a dog in the dungeon meybe he has time for you.");
        }
    }
}
