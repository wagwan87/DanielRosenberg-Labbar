using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.DataStores.Repositories
{
    interface ISellable
    {

        string Brand { get; set; }

        string Name { get; set; }
            
        int Price { get; set; }

        string ProductInformation { get; set; }

        int Warranty { get; set; }

      
    }
}
