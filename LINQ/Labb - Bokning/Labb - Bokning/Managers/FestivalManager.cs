using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class FestivalManager
    {
        public List<Festival> Festivals { get; set; }
        public FestivalManager()
        {
            Festivals = new List<Festival>()
            {
                new Festival ( 90, "Pukkelpop", "Belgium", 3 ),
                new Festival (120, "Roskilde", "Denmark", 2 ),
                new Festival (60, "Emmaboda", "Sweden", 4 )
            };
        }

        public void PrintFestivals()
        {
            foreach (var festival in Festivals)
            {
                Console.WriteLine("The festival costs: {0}, The name is: {1}, You have to travel to: {2} to attend, You will be there for: {3} days",
                    festival.Price, festival.Name, festival.Location, festival.NumberOfDays);
            }
        }
    }
}
