using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace odev2_odeme_form
{
    public class OdemeIslemiFactory
    {
        public IOdeme NesneOlustur(string className)
        {
            var newInstance = Assembly.GetAssembly(typeof(IOdeme)).
                CreateInstance("odev2_odeme_form." + className);
            return (IOdeme)newInstance;
        }
    }
}
