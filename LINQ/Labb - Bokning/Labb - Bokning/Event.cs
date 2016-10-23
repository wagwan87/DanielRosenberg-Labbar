using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb___Bokning
{
    public abstract class Event
    {
       
        public int Price
        { get; set; }

        public string Name
        { get; set; }

        public string Type
        { get; set; }

        public Event(int price, string name) : this()
        {
            Price = price;
            Name = name;
        }
        public Event()
        {
            Price = 100;
            Name = "DefaultName";
            Type = "Event";
        }

        public void BookingInfo()
        {
          
        }
    }
}