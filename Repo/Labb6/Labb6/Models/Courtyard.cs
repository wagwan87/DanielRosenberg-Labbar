using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
    public class Courtyard : IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("It's the glorious courtyard, surprisingly empty");
        }
    }
}
