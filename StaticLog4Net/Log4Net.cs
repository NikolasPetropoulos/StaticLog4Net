using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace StaticLog4Net
{
    public static class Log4Net
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static void L4Method(string ex)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            log.Info(ex);
        }
        

    }
}
