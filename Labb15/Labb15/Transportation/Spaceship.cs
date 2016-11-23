using Labb15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Transportation
{
    class Spaceship : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Push the correct button please...");
            Console.WriteLine("Starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Push the correct button please...");
            Console.WriteLine("Stopping...");
        }

        public void Lock()
        {
            Console.WriteLine("Place your eye close to the scanner...");
            Console.WriteLine("Locking...");
        }

        public void Unlock()
        {
            Console.WriteLine("Place your eye close to the scanner...");
            Console.WriteLine("Unlocking...");
        }
    }
}
