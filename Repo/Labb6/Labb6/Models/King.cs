using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
  public  class King : INonPlayerCharacter, IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("The king is dressed in the finest of clothes and beyond a doubt the most fearsome man you've ever seen.");
        }

        public void Speech()
        {
            Console.WriteLine("Hello! Are you here to help me find the queen? She has been lost for days now...");
        }
    }
}
