using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTConnectAnalyzer
{
    class Log
    {
        internal enum OutputMode { Console, Debug, Writer, Nothing}
        internal static OutputMode outputTo = OutputMode.Debug;
        internal static System.IO.TextWriter writer;
        internal static void Write(object str)
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
            }
        }
        internal static void Stop()
        {
            if (outputTo == OutputMode.Console)
            {
                Console.ReadKey();
            }
        }
    }
}
