using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class Booking
    {
        public Person Person { get; set; }
        public Event Event { get; set; }

        public Booking(Person inputPerson, Event inputEvent)
        {
            Person = inputPerson;
            Event = inputEvent;
        }
    }
}
