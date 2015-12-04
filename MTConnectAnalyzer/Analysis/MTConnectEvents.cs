using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MTConnectAnalyzer.Analysis
{
    public abstract class MTConnectEvent
    {
        public String name = "MTConnectEvent";
    }

    // Defines a PathPosition, typically for a gantry system XYZ coordinates
    public class PathPosition : MTConnectEvent
    {
        public PathPosition(XElement node)
        {
            name = "PathPosition";
        }
    }
}
