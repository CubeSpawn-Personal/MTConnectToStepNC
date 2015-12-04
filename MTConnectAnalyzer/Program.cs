using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MTConnectAnalyzer.Analysis;

namespace MTConnectAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                throw new Exception("Not enough arguments supplied, please supply input MTConnect XML");
            }
            Log.outputTo = Log.OutputMode.Console;

            analyze(args[0]);

            Log.Stop();
        }
        static Analysis.Analysis analyze(String inputFilePath)
        {
            return new Analysis.Analysis(inputFilePath);
        }
    }
}
