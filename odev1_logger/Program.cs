using odev1_logger.abstracts;
using odev1_logger.concretes;

namespace odev1_logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbLog dbLog = new DbLog();
            JsonLog jsonLog = new JsonLog();
            XmlLog xmlLog = new XmlLog();
            EmailLog emailLog = new EmailLog();

            Logger logger = new Logger(emailLog);
            logger.LogKaydet("303");

            ILogger[] loggers = new ILogger[] { dbLog, jsonLog,xmlLog, emailLog };

            foreach (ILogger x in loggers)
            {
                x.log("test log");
            }

        }
    }
}
