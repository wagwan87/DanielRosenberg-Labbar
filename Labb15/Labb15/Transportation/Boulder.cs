using Labb15.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Transportation
{
    class Boulder : IPushable
    {
        public void Push()
        {
            Console.WriteLine("Push it with all your might");
            Console.WriteLine("The boulder moved slightly");
        }
    }
}
