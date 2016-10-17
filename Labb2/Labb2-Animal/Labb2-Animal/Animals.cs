using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
     public abstract class Animals
    {

        public int Age
        { get; set; }

        public int Weight
        { get; set; }

        public string Species
        { get; set; }


        public virtual string Move()
        {
            return String.Format("This animal");
        }

    }
}
