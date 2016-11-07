using Labb7.ProductCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.ProductManagers
{
    class ComputerManager
    {
        public List<Computer> Computers { get; set; }

        public ComputerManager()
        {

            Computers = new List<Computer>()
            {
                new Computer { Brand = "HP", Name = "Spectre", Price = 12000, Warranty = 3,
                    ProductInformation = "A laptop hybrid, great speakers.", NumberOfCores = 2 },
            new Computer
            { Brand = "Dell", Name = "Inspiron", Price = 2500, Warranty = 1,
                 ProductInformation = "A budget laptop, very good battery..", NumberOfCores = 2
            },
            new Computer
            { Brand = "Dell", Name = "Alienware", Price = 20000, Warranty = 4,
                ProductInformation = "A gaming laptop, superb graphics card", NumberOfCores = 4
            } };
        }

        public void PrintComputers()
        {
            foreach (var computer in Computers)
            {
                Console.WriteLine("Brand: {0}, Name: {1}, Price: {2}, Warranty: {3} \nProductinformation: {4} Number of cores: {5}",
                    computer.Brand, computer.Name, computer.Price, computer.Warranty, computer.ProductInformation, computer.NumberOfCores);
            }

        }
    }
}
