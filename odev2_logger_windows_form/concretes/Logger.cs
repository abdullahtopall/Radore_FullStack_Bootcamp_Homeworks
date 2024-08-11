using odev2_logger_windows_form.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_logger_windows_form.concretes
{
    public class Logger
    {
        public ILogger logger;
        public Logger(ILogger logger)
        {
            this.logger = logger;
        }

        public string logKaydet(string message)
        {
            return logger.log(message);
        }
    }
}
