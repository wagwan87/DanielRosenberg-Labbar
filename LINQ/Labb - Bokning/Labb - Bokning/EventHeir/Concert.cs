using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb___Bokning
{
    public class Concert : Event
    {
        public int Length
        { get; set; }

        public string Genre
        { get; set; }

        public Concert(int price, string name, int length, string genre) : base(price, name)
        {
            Type = "Concert";
            Length = length;
            Genre = genre;

        }

        public Concert() : base()
        {
            Length = 0;
            Genre = "DefaultBand";
            Type = "Concert";
        }
    }
}