using Labb7.ProductCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.ProductManagers
{
    class TelevisionManager
    {
        public List<Television> Televisions { get; set; }

        public TelevisionManager()
        {

            Televisions = new List<Television>()
            {
                new Television { Brand = "Finlux", Name = "FWA", Price = 2100, Warranty = 2,
                    ProductInformation = "A very cheap alternative.", TypeOfTv =  "HD Ready" },

            new Television { Brand = "Samsung", Name = "SUHD", Price = 18000, Warranty = 3,
                ProductInformation = "A curved screen and built in wifi.", TypeOfTv = "UHD" },

            new Television { Brand = "Dantax", Name = "DVDC", Price = 2800, Warranty = 1,
                 ProductInformation = "A TV with a built in DVD-player.", TypeOfTv = "LED" } };
        }

        public void PrintTelevisions()
        {
            foreach (var television in Televisions)
            {
                Console.WriteLine("Brand: {0}, Name: {1}, Price: {2}, Warranty: {3}, \nProductinformation: {4}, Type of TV: {5}",
                    television.Brand, television.Name, television.Price, television.Warranty, television.ProductInformation, television.TypeOfTv);
            }

        }
    }
}
