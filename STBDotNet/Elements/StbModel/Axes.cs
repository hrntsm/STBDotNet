using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public class Axis
    {
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("distance")] public double Distance { get; set; }
        [XmlArray("StbNodeid_List")]
        [XmlArrayItem("StbNodeid")]
        public List<NodeId> NodeIdList { get; set; }
    }

    public class XAxis : Axis
    { }

    public class YAxis : Axis
    { }

    public class DrawingAxis
    {
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("start_x")] public double StartX { get; set; }
        [XmlAttribute("start_y")] public double StartY { get; set; }
        [XmlAttribute("end_x")] public double EndX { get; set; }
        [XmlAttribute("end_y")] public double EndY { get; set; }
    }
}