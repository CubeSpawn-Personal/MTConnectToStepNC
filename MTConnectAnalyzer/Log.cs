using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTConnectAnalyzer
{
    public abstract class LogWriter
    {
        public abstract void Write(object o);
    }

    public class Log
    {
        public enum OutputMode { Console, Debug, Writer, LogWriter, Nothing};
        public static OutputMode outputTo = OutputMode.Debug;
        public static System.IO.TextWriter writer;
        public static LogWriter logwriter;
        public static void Write(object str)
        {
            if (outputTo == OutputMode.Console)
            {
                Console.WriteLine(str);
            }else if (outputTo == OutputMode.Debug)
            {
                System.Diagnostics.Debug.WriteLine(str);
            }else if (outputTo == OutputMode.Writer)
            {
                writer.WriteLine(outputTo);
            }else if (outputTo == OutputMode.LogWriter)
            {
                logwriter.Write(str);
            }
        }
        public static void Stop()
        {
            if (outputTo == OutputMode.Console)
            {
                Console.ReadKey();
            }
        }
    }
}
