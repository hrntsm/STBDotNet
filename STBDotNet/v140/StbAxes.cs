using System.Collections.Generic;
using System.Xml.Serialization;
namespace STBDotNet.v140
{
    public abstract class StbAxis
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("distance")] public double Distance { get; set; }
        [XmlArray("StbNodeid_List")]
        [XmlArrayItem("StbNodeid")] public List<NodeId> NodeIdList { get; set; }
    }

    public class StbXAxis : StbAxis
    {
        public override string ToString()
        {
            int nodeCount = NodeIdList?.Count ?? 0;
            return $"StbXAxis Dist={Distance}, Nodes:{nodeCount}";
        }
    }

    public class StbYAxis : StbAxis
    {
        public override string ToString()
        {
            int nodeCount = NodeIdList?.Count ?? 0;
            return $"StbYAxis Dist={Distance}, Nodes:{nodeCount}";
        }
    }

    public class StbDrawingAxis
    {
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("start_x")] public double StartX { get; set; }
        [XmlAttribute("start_y")] public double StartY { get; set; }
        [XmlAttribute("end_x")] public double EndX { get; set; }
        [XmlAttribute("end_y")] public double EndY { get; set; }
    }
}