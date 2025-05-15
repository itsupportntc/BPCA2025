using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPCACondoDeficiencies { 
    public static class LogWriter
    {
        internal static void LogError(string logMessage)
        {
            try
            {
                using (StreamWriter w = File.AppendText(@"C:\inetpub\websites\condodeficiencies_mvc\errorlog.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch 
            {
            }
        }

        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
                txtWriter.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
