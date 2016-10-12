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

            //Dog dog1 = new Dog
            //{
            //    Name = "Dogmeat",
            //    Age = 8,
            //    Breed = "German Shepherd"
            //};

            //Dog dog2 = new Dog
            //{
            //    Name = "Lassie",
            //    Age = 40,
            //    Breed = "Collie",
            //};

            //Dog dog3 = new Dog
            //{
            //    Name = "Beethoven",
            //    Age = 12,
            //    Breed = "St. Bernard",
            //};

            //Console.WriteLine(dog1.Name);

            //Console.WriteLine(dog1.Age);

            //Console.WriteLine(dog1.Breed);

            //Console.WriteLine(dog2.Name);

            //Console.WriteLine(dog2.Age);

            //Console.WriteLine(dog2.Breed);

            //Console.WriteLine(dog3.Name);

            //Console.WriteLine(dog3.Age);

            //Console.WriteLine(dog3.Breed);



            List<Dog> doggies = new List<Dog>()
            {
                new Dog {Name = "Dogmeat" , Age = 4, Breed = "German Shepherd" },
                new Dog {Name = "Lassie" , Age = 40, Breed = "Collie" },
                new Dog {Name = "Beethoven" , Age = 15, Breed = "St. Bernhard" },
            };

           

            bool continueloop = true;

            do
            {
                Menu.StartMenu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        foreach (var dogs in doggies)
                        {
                            Console.WriteLine(dogs.Introduction());


                        }

                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();



                        break;

                    case 2:
                        Console.WriteLine("Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Age");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Breed");
                        string breed = Console.ReadLine();

                        doggies.Add(new Dog { Name = name, Age = age, Breed = breed });

                        break;

                    case 3:
                        Console.WriteLine("Which would you like to remove?");
                        int remove = int.Parse(Console.ReadLine());
                        doggies.RemoveAt(remove);

                        Console.WriteLine("Press any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();


                        break;

                    case 4:
                        continueloop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");



                        break;
                }
                } while (continueloop == true) ;


            }


    }

}

