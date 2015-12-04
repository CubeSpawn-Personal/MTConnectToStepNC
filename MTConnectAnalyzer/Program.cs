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
            if (args.Length == 0)
            {
                throw new Exception("Not enough arguments supplied, please supply input MTConnect XML and optionally output stepnc path");
            }
            Log.outputTo = Log.OutputMode.Console;

            Analysis.Analysis analysis = analyze(args[0]);

            if (args.Length == 2)
            {
                generate(analysis, args[1]);
            }

            Log.Stop();
        }
        public static Analysis.Analysis analyze(String inputFilePath)
        {
            return new Analysis.Analysis(inputFilePath);
        }
        public static void generate(Analysis.Analysis analysis, String outputPath)
        {
            StepNC.StepNC.generateFromAnalysis(analysis, outputPath);
        }
    }
}
