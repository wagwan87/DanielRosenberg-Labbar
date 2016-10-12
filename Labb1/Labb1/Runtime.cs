using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Runtime
    {
        public void Start()
        {

            Dog dog1 = new Dog
            {
                Name = "Dogmeat",
                Age = 8,
                Breed = "German Shepherd"
            };

            Dog dog2 = new Dog
            {
                Name = "Lassie",
                Age = 40,
                Breed = "Collie",
            };

            Dog dog3 = new Dog
            {
                Name = "Beethoven",
                Age = 12,
                Breed = "St. Bernard",
            };

            Console.WriteLine(dog1.Name);

            Console.WriteLine(dog1.Age);

            Console.WriteLine(dog1.Breed);

            Console.WriteLine(dog2.Name);

            Console.WriteLine(dog2.Age);

            Console.WriteLine(dog2.Breed);

            Console.WriteLine(dog3.Name);

            Console.WriteLine(dog3.Age);

            Console.WriteLine(dog3.Breed);

            List <Dog> doggies = new List<Dog> 

        }

    }
}
