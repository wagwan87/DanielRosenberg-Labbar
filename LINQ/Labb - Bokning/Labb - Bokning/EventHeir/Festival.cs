using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb___Bokning
{
    public class Festival : Event
    {
        public string Location
        { get; set; }

        public int NumberOfDays
        { get; set; }

        public Festival(int price, string name, string location, int numberofdays) : base(price, name)
        {
            Location = location;
            NumberOfDays = numberofdays;
            Type = "Festival";

        }
        public Festival() : base()
        {
            Location = "DefaultLocation";
            NumberOfDays = 0;
            Type = "Festival";
        }
    }
}