using Labb15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Transportation
{
    class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Start peddling...");
            Console.WriteLine("Rolling...");
        }

        public void Stop()
        {
            Console.WriteLine("Squeeze the brake on the handlebar...");
            Console.WriteLine("Stopping...");
        }

        public void Lock()
        {
            Console.WriteLine("Place the lock around the tire...");
            Console.WriteLine("Locking...");
        }

        public void Unlock()
        {
            Console.WriteLine("Put the key inside the lock...");
            Console.WriteLine("Unlocking...");
        }
    }
}
