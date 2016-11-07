using Labb7.ProductCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.ProductManagers
{
    class CellphoneManager
    {
        public List<Cellphone> Cellphones { get; set; }

        public CellphoneManager()
        {

            Cellphones = new List<Cellphone>()
            {
                new Cellphone { Brand = "HTC", Name = "One", Price = 4999, Warranty = 2, SizeOfScreen = 6,
                    ProductInformation = "A nice phone with a fast processor." },
            new Cellphone
            {
                Brand = "Samsung",
                Name = "Edge",
                Price = 5999,
                Warranty = 3,
                SizeOfScreen = 7,
                ProductInformation = "A cutting edge screen and the current flagship model."
            },
            new Cellphone
            {
                Brand = "Huawei",
                Name = "Honor",
                Price = 3999,
                Warranty = 1,
                SizeOfScreen = 5,
                ProductInformation = "A very good phone concidering it's price."
            } };
        }

        public void PrintCellphones()
        {
            foreach (var cellphone in Cellphones)
            {
                Console.WriteLine("Brand: {0}, Name: {1}, Price: {2}, Warranty: {3}, Size of screen: {4} \nProductinformation: {5}",
                    cellphone.Brand, cellphone.Name, cellphone.Price, cellphone.Warranty, cellphone.SizeOfScreen, cellphone.ProductInformation);
            }

        }
    }
}
