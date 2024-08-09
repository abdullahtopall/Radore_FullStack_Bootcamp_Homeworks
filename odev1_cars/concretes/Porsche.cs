using odev1_cars.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_cars.concretes
{
    public class Porsche : Car,IFast
    {
        public override double Benzin => 80.0;

        public void goingFast()
        {
            Console.WriteLine("porsche çok hızlı gidiyor");
        }
    }
}
