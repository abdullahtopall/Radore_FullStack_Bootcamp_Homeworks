using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_odeme_form
{
    public class MailOrder : IOdeme
    {
        public string ode(double tutar)
        {
            return "Mail Order ile " + tutar + " TL ödeme yapıldı";
        }
    }
}
