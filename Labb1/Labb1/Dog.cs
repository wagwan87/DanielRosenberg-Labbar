using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public Dog()
        {

        }

        public string Introduction()
        {
            return String.Format("Hello! My dogs name is {0} and he is {1} years old. He is a {2}", Name, Age, Breed);
        }

    }
}
