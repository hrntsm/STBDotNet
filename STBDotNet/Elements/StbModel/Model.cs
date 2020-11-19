using System.Collections.Generic;
using System.Xml.Linq;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbModel.StbMember;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel
{
    public class Model : StbSerializable, IGuid, IStbTag
    {
        public string Guid { get; set; }
        public string[] StbTag { get; } = {"StbModel", ""};
        public List<Node> Nodes { get; set; } = new List<Node>();
        public Axes Axes { get; set; }
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