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

    public class Point3
    {
        float x, y, z;
        public Point3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Point3 fromNodeValue(string v)
        {
            string[] coords = v.Split(' ');
            return new Point3(float.Parse(coords[0]), float.Parse(coords[1]), float.Parse(coords[2]));
        }
    }

    // Defines a PathPosition, typically for a gantry system XYZ coordinates
    public class PathPosition : MTConnectEvent
    {
        public Point3 coords;
        public PathPosition(XElement node)
        {
            name = "PathPosition";
            coords = Point3.fromNodeValue(node.Value);
        }
    }
}
