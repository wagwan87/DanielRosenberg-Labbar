using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class Movie : Event
    {
        public int AgeRating
        { get; set; }

        public string LeadActor
        { get; set; }

        public Movie(int price, string name, int agerating, string leadactor) : base(price, name)
        {
            AgeRating = agerating;
            LeadActor = leadactor;
            Type = "Movie";

        }

        public Movie() : base()
        {
            AgeRating = 0;
            LeadActor = "DefaultActor";
            Type = "Movie";
        }
    }
}
