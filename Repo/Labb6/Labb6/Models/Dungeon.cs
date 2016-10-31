using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
   public class Dungeon : IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("It's a dark and scary dungeon with hardly any light.");
        }
    }
}
