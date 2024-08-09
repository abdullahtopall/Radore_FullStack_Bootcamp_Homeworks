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

            ILogger[] loggers = new ILogger[] { dbLog, jsonLog,xmlLog };

            dbLog.log("dblog test");
            jsonLog.log("jsonlog test");
            xmlLog.log("xmllog test");

            foreach (ILogger logger in loggers)
            {
                logger.log("test log");
            }

        }
    }
}
