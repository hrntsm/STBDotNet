using System.Collections.Generic;
using STBDotNet.Elements.StbModel.StbMember;

namespace STBDotNet.Elements.StbModel
{
    public class Model
    {
        public List<Node> Nodes { get; set; }
        public Axis Axis { get; set; }
        public List<Story> Stories { get; set; }
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