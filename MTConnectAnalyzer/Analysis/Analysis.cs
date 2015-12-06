using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Threading;

namespace MTConnectAnalyzer.Analysis
{
    public class Analysis
    {
        public List<MTConnectEvent> timeline = new List<MTConnectEvent>();
        public Analysis(String pathToXML)
        {
            Log.Write("Running MTConnect Analysis");
            // Read and deserialize the MTConnect Data
            XmlSerializer serializer = new XmlSerializer(typeof(MTConnectStreamsType));
            Stream reader = new FileStream(pathToXML, FileMode.Open);
            MTConnectStreamsType data = (MTConnectStreamsType) serializer.Deserialize(reader);
            Log.Write("MT Connect Data Read into MTConnectStreamsType");
            Log.Write("Creation Time " + data.Header.creationTime);

            // TODO use other device streams
            DeviceStreamType deviceStream = data.Streams.First();
            // Turns out these paths are useless- no sample information :(
            /*
            List<ComponentStreamType> paths = deviceStream.ComponentStream.Where((cs) => cs.component == "Path").ToList();
            Log.Write("Paths detected: " + paths.Count);
            foreach (ComponentStreamType path in paths){
                List<SampleType> a = path.Samples.ToList();
                Log.Write("Loaded path");
            }
            */

            reader.Close();

            // Switching to manual mode...
            XDocument xd = XDocument.Load(pathToXML);
            List<XElement> sequenceElements = xd.XPathSelectElements("//*[@sequence]").OrderBy((elm) =>
            {
                return Int32.Parse(elm.Attribute("sequence").Value);
            }).ToList();

            int unknownElements = 0;
            int parseErrors = 0;

            int i = 0;
            foreach (XElement elm in sequenceElements)
            {
                try {
                    int seq = Int32.Parse(elm.Attribute("sequence").Value);
                    //Log.Write("SEQ" + seq + " : " + elm.Name);
                    if (elm.Name.LocalName.Equals("PathPosition"))
                    {
                        timeline.Add(new PathPosition(elm));
                    }
                    else
                    {
                       // Log.Write("[" + seq + "] Unregistered Event: " + elm.Name.LocalName);
                        unknownElements++;
                    }
                }catch(Exception e)
                {
                    parseErrors++;
                    Log.Write("[" + elm.Attribute("sequence").Value + "] Parse Error " + e);
                }
            }
            Log.Write("XML Parsing Complete");
            Log.Write("[" + timeline.Count((e) => e.name == "PathPosition") + "] PathPositions");
            Log.Write("[" + unknownElements + "] Unregistered Events ("+ (1 - ((float)unknownElements) / sequenceElements.Count) * 100+"% Coverage)");
            Log.Write("[" + parseErrors + "] Parse Errors ");
        }

        public void outputStepNC(string templatePath, string outputPath)
        {
            StepNC.StepNC.generateFromAnalysis(this, templatePath, outputPath);
        }
    }
}
