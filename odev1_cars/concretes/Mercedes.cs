using odev1_cars.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_cars.concretes
{
    public class Mercedes : Car, IFlying, ISwimming
    {
        public override double Benzin => 70.0;

        public void fly()
        {
            Console.WriteLine("mercedes havada uçuyor");
        }

        public void swim()
        {
            Console.WriteLine("mercedes denizde yüzüyor");
        }
    }
}
