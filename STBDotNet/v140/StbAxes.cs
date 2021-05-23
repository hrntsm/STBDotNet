using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel
{
    public abstract class Axis
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("distance")] public double Distance { get; set; }
        [XmlArray("StbNodeid_List")]
        [XmlArrayItem("StbNodeid")] public List<NodeId> NodeIdList { get; set; }
    }

    public class XAxis : Axis
    {
        public override string ToString()
        {
            int nodeCount = NodeIdList?.Count ?? 0;
            return $"XAxis Dist={Distance}, Nodes:{nodeCount}";
        }
    }

    public class YAxis : Axis
    {
        public override string ToString()
        {
            int nodeCount = NodeIdList?.Count ?? 0;
            return $"YAxis Dist={Distance}, Nodes:{nodeCount}";
        }
    }

    public class DrawingAxis
    {
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("start_x")] public double StartX { get; set; }
        [XmlAttribute("start_y")] public double StartY { get; set; }
        [XmlAttribute("end_x")] public double EndX { get; set; }
        [XmlAttribute("end_y")] public double EndY { get; set; }
    }
}