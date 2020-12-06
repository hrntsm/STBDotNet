using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using STBDotNet.Elements.StbCommon;
using STBDotNet.Elements.StbModel.StbMember;
using STBDotNet.Elements.StbModel.StbSection;
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
        public List<Story> Stories { get; set; }
        [XmlElement("StbMembers")]
        public Members Members { get; set; }
        [XmlArray("StbSections")]
        [XmlArrayItem("StbSecColumn_RC", Type = typeof(ColumnRc))]
        [XmlArrayItem("StbSecColumn_S", Type = typeof(ColumnS))]
        [XmlArrayItem("StbSecColumn_SRC", Type = typeof(ColumnSrc))]
        [XmlArrayItem("StbSecColumn_CFT", Type = typeof(ColumnCft))]
        [XmlArrayItem("StbSecBeam_RC", Type = typeof(BeamRc))]
        [XmlArrayItem("StbSecBeam_S", Type = typeof(BeamS))]
        [XmlArrayItem("StbSecBeam_SRC", Type = typeof(BeamSrc))]
        [XmlArrayItem("StbSecBrace_S", Type = typeof(BraceS))]
        [XmlArrayItem("StbSecSlab_RC", Type = typeof(SlabRc))]
        [XmlArrayItem("StbSecSlab_Deck", Type = typeof(SlabDeck))]
        [XmlArrayItem("StbSecSlab_Precast", Type = typeof(SlabPrecast))]
        [XmlArrayItem("StbSecWall_RC", Type = typeof(WallRc))]
        [XmlArrayItem("StbSecFoundation_RC", Type = typeof(FoundationRc))]
        [XmlArrayItem("StbSecPile_RC", Type = typeof(PileRc))]
        [XmlArrayItem("StbSecOpen_RC", Type = typeof(OpenRc))]
        [XmlArrayItem("StbSecSteel", Type = typeof(Steel))]
        public List<Section> Sections { get; set; }
        public Joints Joints { get; set; }
    }

    public class Section
    {
    }

    public class Joints
    {
    }
}