using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb___Bokning
{
    class Person
    {
        public string Name { get; set; }
        
        public Person()
        {
            Name = "Pelle Svanslös";
        }
        public Person(string inputName)
        {
            Name = inputName;
        }
    }
}
