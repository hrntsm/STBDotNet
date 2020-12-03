using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbModel.StbMember;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public class Model
    {
        [XmlArray("StbNodes")]
        [XmlArrayItem("StbNode")]
        public List<Node> Nodes { get; set; }
        [XmlArray("StbAxes")]
        [XmlArrayItem("StbX_Axis", Type = typeof(XAxis))]
        [XmlArrayItem("StbY_Axis", Type = typeof(YAxis))]
        public List<Axis> Axes { get; set; }
        [XmlArray("StbDrawAxes")]
        [XmlArrayItem("StbDrawAxis")]
        public List<DrawingAxis> DrawingAxises { get; set; }
        [XmlArray("StbStories")]
        [XmlArrayItem("StbStory")]
        public List<Story> Stories { get; set; } = new List<Story>();
        public Members Members { get; set; }
        public Sections Sections { get; set; }
        public Joints Joints { get; set; }
    }

    public class Sections
    {
    }

    public class Joints
    {
    }
}