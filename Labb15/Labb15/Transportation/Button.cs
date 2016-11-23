using Labb15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Transportation
{
    class Button : IPushable
    {
             public void Push()
        {
            Console.WriteLine("Push the button");
            Console.WriteLine("Somethings happening");
        }
    }
}
