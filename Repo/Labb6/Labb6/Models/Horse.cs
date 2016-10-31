using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    class Horse : IEnvironment, INonPlayerCharacter
    {
        public void Observe()
        {
            Console.WriteLine("It's a beautiful stallion.");
        }

        public void Speech()
        {
            Console.WriteLine("*Horse sound*");
        }
    }
}
