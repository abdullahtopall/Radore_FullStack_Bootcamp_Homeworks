using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_odeme_form
{
    public class GooglePay : IOdeme
    {
        public string ode(double tutar)
        {
            return "Google Pay ile " + tutar + " TL ödeme yapıldı";
        }
    }
}
