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
        public static void generateFromAnalysis(Analysis.Analysis analysis, String basePath, String outputPath)
        {
            List<MTConnectEvent> timeline = analysis.timeline;

            Log.Write("Generating StepNC Data");
            STEPNCLib.AptStepMaker apt = new STEPNCLib.AptStepMaker();
            STEPNCLib.Finder find = new STEPNCLib.Finder();

            Log.Write("Using template StepNC file " + basePath);
            apt.Open238(basePath);
            find.Open238(basePath);

            long wp_id = find.GetMainWorkplan();
            apt.NestWorkplanAfter("Workplan for MTConnect results", find.GetWorkplanExecutableCount(wp_id) + 1, wp_id);

            apt.Workingstep("testing");

            apt.LoadTool(101);
            apt.Rapid();

            // Add all the path positions
            foreach (PathPosition pp in timeline)
            {
                apt.GoToXYZ("seq" + pp.sequence, pp.coords.x * mmtoinch, pp.coords.y * mmtoinch, pp.coords.z * mmtoinch);
            }
            apt.SaveAsModules(outputPath);
            Log.Write("StepNC Written to " + outputPath);
        }
    }
}
