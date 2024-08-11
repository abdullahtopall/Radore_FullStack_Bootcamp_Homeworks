using odev2_logger_windows_form.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace odev2_logger_windows_form.concretes
{
    public class LogIslemiFactory
    {
        public ILogger NesneOlustur(string className)
        {
            var newInstance = Assembly.GetAssembly(typeof(ILogger)).CreateInstance
                ("odev2_logger_windows_form.concretes." + className);
            return (ILogger)newInstance;
        }
    }
}
