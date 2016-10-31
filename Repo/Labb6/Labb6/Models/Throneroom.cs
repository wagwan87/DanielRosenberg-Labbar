using Labb6.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Models
{
   public class Throneroom : IEnvironment
    {
        public void Observe()
        {
            Console.WriteLine("The throneroom is beautiful, candles everywhere and enough gold to feed an entire country.");
        }
    }
}
