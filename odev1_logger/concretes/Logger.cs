using odev1_logger.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_logger.concretes
{
    public class Logger
    {
        public ILogger logger;
        public Logger(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogKaydet(string message)
        {
            logger.log(message);
        }
        
        
    }
}
