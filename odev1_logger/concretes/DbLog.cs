using odev1_logger.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_logger.concretes
{
    public class DbLog : ILogger
    {
        public void log(string code)
        {
            Console.WriteLine(code+" db'ye kaydedildi.");
        }
    }
}
