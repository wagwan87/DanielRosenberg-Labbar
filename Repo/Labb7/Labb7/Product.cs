using Labb7.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class Product : ISellable
    {
        public string Brand { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string ProductInformation { get; set; }

        public int Warranty { get; set; }
    }
}
