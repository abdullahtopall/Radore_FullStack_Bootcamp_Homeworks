using odev2_logger_windows_form.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_logger_windows_form.concretes
{
    public class XmlLog : ILogger
    {
        public string log(string code)
        {
            return code + " xml'e kaydedildi.";
        }
    }
}
