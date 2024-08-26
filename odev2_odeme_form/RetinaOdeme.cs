using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_odeme_form
{
    public class RetinaOdeme : IOdeme
    {
        public string ode(double tutar)
        {
            return "Retina ile " + tutar + " TL ödeme yapıldı.";
        }
    }
}
