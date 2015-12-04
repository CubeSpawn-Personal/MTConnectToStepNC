using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTConnectAnalyzer.Analysis;

namespace MTConnectAnalyzer.StepNC
{
    public class StepNC
    {
        const double mmtoinch = 0.0393701;
        public static void generateFromAnalysis(Analysis.Analysis analysis, String outputPath)
        {
            List<MTConnectEvent> timeline = analysis.timeline;

            Log.Write("Generating StepNC Data");

        }
    }
}
