using odev1_cars.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_cars.concretes
{
    public class Bmw : IFlying, ISwimming, IFast
    {
        public void fly()
        {
            Console.WriteLine("bmw havada uçuyor");
        }

        public void goingFast()
        {
            Console.WriteLine("bmw çok hızlı gidiyor");
        }

        public void swim()
        {
            Console.WriteLine("bmw denizde yüzüyor");
        }
    }
}
