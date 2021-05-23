using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbModel
    {
        [XmlArray("StbNodes")]
        [XmlArrayItem("StbNode")] public List<StbNode> Nodes { get; set; }
        //
        [XmlArray("StbAxes")]
        [XmlArrayItem("StbX_Axis", Type = typeof(StbXAxis))]
        [XmlArrayItem("StbY_Axis", Type = typeof(StbYAxis))] public List<StbAxis> Axes { get; set; }
        //
        [XmlArray("StbDrawingAxes")]
        [XmlArrayItem("StbDrawingAxis")] public List<StbDrawingAxis> DrawingAxises { get; set; }
        //
        [XmlArray("StbStories")]
        [XmlArrayItem("StbStory")] public List<StbStory> Stories { get; set; }
        //
        [XmlElement("StbMembers")] public StbMembers StbMembers { get; set; }
        //
        [XmlArray("StbSections")]
        [XmlArrayItem("StbSecColumn_RC", Type = typeof(StbSecColumnRc))]
        [XmlArrayItem("StbSecColumn_S", Type = typeof(StbSecColumnS))]
        [XmlArrayItem("StbSecColumn_SRC", Type = typeof(StbSecColumnSrc))]
        [XmlArrayItem("StbSecColumn_CFT", Type = typeof(StbSecColumnCft))]
        [XmlArrayItem("StbSecBeam_RC", Type = typeof(StbSecBeamRc))]
        [XmlArrayItem("StbSecBeam_S", Type = typeof(StbSecBeamS))]
        [XmlArrayItem("StbSecBeam_SRC", Type = typeof(StbSecBeamSrc))]
        [XmlArrayItem("StbSecBrace_S", Type = typeof(StbSecBraceS))]
        [XmlArrayItem("StbSecSlab_RC", Type = typeof(StbSecSlabRc))]
        [XmlArrayItem("StbSecSlab_Deck", Type = typeof(StbSecSlabDeck))]
        [XmlArrayItem("StbSecSlab_Precast", Type = typeof(StbSecSlabPrecast))]
        [XmlArrayItem("StbSecWall_RC", Type = typeof(StbSecWallRc))]
        [XmlArrayItem("StbSecFoundation_RC", Type = typeof(StbSecFoundationRc))]
        [XmlArrayItem("StbSecPile_RC", Type = typeof(StbSecPileRc))]
        [XmlArrayItem("StbSecOpen_RC", Type = typeof(StbSecOpenRc))]
        [XmlArrayItem("StbSecSteel", Type = typeof(StbSecSteel))] public List<StbSection> Sections { get; set; }
        //
        [XmlArray("StbJoints")]
        [XmlArrayItem("StbJointBeam_H", Type = typeof(StbJointBeamH))]
        [XmlArrayItem("StbJointColumn_H", Type = typeof(StbJointColumnH))]
        [XmlArrayItem("StbJointColumn_T", Type = typeof(StbJointColumnT))]
        [XmlArrayItem("StbJointColumn_CROSS", Type = typeof(StbJointColumnCross))] public List<StbJoint> Joints { get; set; }
    }
}