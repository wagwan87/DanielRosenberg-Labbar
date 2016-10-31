using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    class Stables : IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("The stables are fairly large, but there is only one horse here right now, strange.");
        }
    }
}
