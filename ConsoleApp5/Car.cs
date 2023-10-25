using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Car
    {
        public virtual void Ljud()
        {
            
        }
    }

    class Bike : Car
    {
        public override void Ljud()
        {
            Console.WriteLine("brrr");
        }

    }
}
