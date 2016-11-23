using Labb15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Transportation
{
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Put the key inside the ignition...");
            Console.WriteLine("Starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Press your foot on the brake pedal...");
            Console.WriteLine("Stopping...");
        }

        public void Lock()
        {
            Console.WriteLine("Push the lock-button on the keychain...");
            Console.WriteLine("Locking...");
        }

        public void Unlock()
        {
            Console.WriteLine("Push the unlock-button on the keychain...");
            Console.WriteLine("Unlocking...");
        }
    }
}
