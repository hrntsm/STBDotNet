using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbMember
{
    public class Members
    {
        [XmlArray("StbColumns")]
        [XmlArrayItem("StbColumn")] public List<Column> Columns { get; set; }
        [XmlArray("StbPosts")]
        [XmlArrayItem("StbPost")] public List<Post> Posts { get; set; }
        [XmlArray("StbGirders")]
        [XmlArrayItem("StbGirder")] public List<Girder> Girders { get; set; }
        [XmlArray("StbBeams")]
        [XmlArrayItem("StbBeam")] public List<Beam> Beams { get; set; }
        [XmlArray("StbBraces")]
        [XmlArrayItem("StbBrace")] public List<Brace> Braces { get; set; }
        [XmlArray("StbSlabs")]
        [XmlArrayItem("StbSlab")] public List<Slab> Slabs { get; set; }
        [XmlArray("StbWalls")]
        [XmlArrayItem("StbWall")] public List<Wall> Walls { get; set; }
        [XmlArray("StbFootings")]
        [XmlArrayItem("StbFooting")] public List<Footing> Footings { get; set; }
        [XmlArray("StbStrip_Footings")]
        [XmlArrayItem("StbStrip_Footing")] public List<StripFooting> StripFootings { get; set; }
        [XmlArray("StbPiles")]
        [XmlArrayItem("StbPile")] public List<Pile> Piles { get; set; }
        [XmlArray("StbFoundationColumns")]
        [XmlArrayItem("StbFoundationColumn")] public List<FoundationColumn> FoundationColumns { get; set; }
        [XmlArray("StbParapets")]
        [XmlArrayItem("StbParapet")] public List<Parapet> Parapets { get; set; }
    }

    public class FrameBase : MemberBase, IFrame
    {
        [XmlAttribute("idNode_start")] public int IdNodeStart { get; set; }
        [XmlAttribute("idNode_end")] public int IdNodeEnd { get; set; }
        [XmlAttribute("rotate")] public double Rotate { get; set; }
        [XmlAttribute("offset_start_X")] [DefaultValue(0d)] public double OffsetStartX { get; set; }
        [XmlAttribute("offset_start_Y")] [DefaultValue(0d)] public double OffsetStartY { get; set; }
        [XmlAttribute("offset_start_Z")] [DefaultValue(0d)] public double OffsetStartZ { get; set; }
        [XmlAttribute("offset_end_X")] [DefaultValue(0d)] public double OffsetEndX { get; set; }
        [XmlAttribute("offset_end_Y")] [DefaultValue(0d)] public double OffsetEndY { get; set; }
        [XmlAttribute("offset_end_Z")] [DefaultValue(0d)] public double OffsetEndZ { get; set; }
        [XmlAttribute("condition_start")] public string ConditionStart { get; set; }
        [XmlAttribute("condition_end")] public string ConditionEnd { get; set; }
        [XmlAttribute("joint_start")] [DefaultValue(0d)] public double JointStart { get; set; }
        [XmlAttribute("joint_end")] [DefaultValue(0d)] public double JointEnd { get; set; }
        [XmlAttribute("kind_joint_start")] public string KindJointStart { get; set; }
        [XmlAttribute("kind_joint_end")] public string KindJointEnd { get; set; }
        [XmlAttribute("Joint_id_start")] [DefaultValue(0)] public int JointIdStart { get; set; }
        [XmlAttribute("Joint_id_end")] [DefaultValue(0)] public int JointIdEnd { get; set; }
    }

    public class Column : MemberBase, IFrame
    {
        [XmlAttribute("idNode_bottom")] public int IdNodeStart { get; set; }
        [XmlAttribute("idNode_top")] public int IdNodeEnd { get; set; }
        [XmlAttribute("rotate")] public double Rotate { get; set; }
        [XmlAttribute("offset_bottom_X")] [DefaultValue(0d)] public double OffsetStartX { get; set; }
        [XmlAttribute("offset_bottom_Y")] [DefaultValue(0d)] public double OffsetStartY { get; set; }
        [XmlAttribute("offset_bottom_Z")] [DefaultValue(0d)] public double OffsetStartZ { get; set; }
        [XmlAttribute("offset_top_X")] [DefaultValue(0d)] public double OffsetEndX { get; set; }
        [XmlAttribute("offset_top_Y")] [DefaultValue(0d)] public double OffsetEndY { get; set; }
        [XmlAttribute("offset_top_Z")] [DefaultValue(0d)] public double OffsetEndZ { get; set; }
        [XmlAttribute("condition_bottom")] public string ConditionStart { get; set; }
        [XmlAttribute("condition_top")] public string ConditionEnd { get; set; }
        [XmlAttribute("joint_bottom")] [DefaultValue(0d)] public double JointStart { get; set; }
        [XmlAttribute("joint_top")] [DefaultValue(0d)] public double JointEnd { get; set; }
        [XmlAttribute("kind_joint_bottom")] public string KindJointStart { get; set; }
        [XmlAttribute("kind_joint_top")] public string KindJointEnd { get; set; }
        [XmlAttribute("Joint_id_bottom")] [DefaultValue(0)] public int JointIdStart { get; set; }
        [XmlAttribute("Joint_id_top")] [DefaultValue(0)] public int JointIdEnd { get; set; }
        [XmlAttribute("offset_X")] [DefaultValue(0d)] public double OffsetX { get; set; }
        [XmlAttribute("offset_Y")] [DefaultValue(0d)] public double OffsetY { get; set; }
        [XmlAttribute("thickness_ex_start_X")] [DefaultValue(0d)] public double ThicknessExStartX { get; set; }
        [XmlAttribute("thickness_ex_start_Y")] [DefaultValue(0d)] public double ThicknessExStartY { get; set; }
        [XmlAttribute("thickness_ex_end_X")] [DefaultValue(0d)] public double ThicknessExEndX { get; set; }
        [XmlAttribute("thickness_ex_end_Y")] [DefaultValue(0d)] public double ThicknessExEndY { get; set; }
    }

    public class Post : Column
    { }

    public class Girder : FrameBase
    {
        [XmlAttribute("section_io_start")] public string SectionIOStart { get; set; }
        [XmlAttribute("section_io_end")] public string SectionIOEnd { get; set; }
        [XmlAttribute("isFoundation")] public string IsFoundation { get; set; }
        [XmlAttribute("offset")] [DefaultValue(0d)] public double Offset { get; set; }
        [XmlAttribute("level")] [DefaultValue(0d)] public double Level { get; set; }
        [XmlAttribute("thickness_ex_top")] [DefaultValue(0d)] public double ThicknessExTop { get; set; }
        [XmlAttribute("thickness_ex_bottom")] [DefaultValue(0d)] public double ThicknessExBottom { get; set; }
        [XmlAttribute("thickness_ex_right")] [DefaultValue(0d)] public double ThicknessExRight { get; set; }
        [XmlAttribute("thickness_ex_left")] [DefaultValue(0d)] public double ThicknessExLeft { get; set; }
        [XmlAttribute("haunch_start")] [DefaultValue(0d)] public double HaunchStart { get; set; }
        [XmlAttribute("haunch_end")] [DefaultValue(0d)] public double HaunchEnd { get; set; }
        [XmlAttribute("kind_haunch_start")] public string KindHaunchStart { get; set; }
        [XmlAttribute("kind_haunch_end")] public string KindHaunchEnd { get; set; }
        [XmlAttribute("type_haunch_H")] public string TypeHaunchH { get; set; }
        [XmlAttribute("type_haunch_V")] public string TypeHaunchV { get; set; }
    }

    public class Beam : Girder
    { }

    public class Brace : FrameBase
    {
        [XmlAttribute("future_brace")] public string FutureBrace { get; set; }
    }

    public class Slab : PlateBase
    {
        [XmlAttribute("kind_slab")] public string KindSlab { get; set; }
        [XmlAttribute("level")] public double Level { get; set; }
        [XmlAttribute("thickness_ex_upper")] public double ThicknessExUpper { get; set; }
        [XmlAttribute("thickness_ex_bottom")] public double ThicknessExBottom { get; set; }
        [XmlAttribute("dir_load")] public string DirLoad { get; set; }
        [XmlAttribute("angle_load")] public double AngleLoad { get; set; }
        [XmlAttribute("isFoundation")] public string IsFoundation { get; set; }
        [XmlAttribute("type_haunch")] public string TypeHaunch { get; set; }
        [XmlArray("StbSlabOffset_List")]
        [XmlArrayItem("StbSlabOffset")] public List<SlabOffset> SlabOffsets { get; set; }
    }

    public class SlabOffset
    {
        [XmlAttribute("offset_X")] public double OffsetX { get; set; }
        [XmlAttribute("offset_Y")] public double OffsetY { get; set; }
    }

    public class Wall : PlateBase
    {
        [XmlAttribute("kind_layout")] public string KindLayout { get; set; }
        [XmlAttribute("offset")] public double Offset { get; set; }
        [XmlAttribute("thickness_ex_right")] public double ThicknessExRight { get; set; }
        [XmlAttribute("thickness_ex_left")] public double ThicknessExLeft { get; set; }
        [XmlAttribute("kind_wall")] public string KindWall { get; set; }
        [XmlAttribute("slit_upper")] public double SplitUpper { get; set; }
        [XmlAttribute("slit_bottom")] public double SplitBottom { get; set; }
        [XmlAttribute("slit_right")] public double SplitRight { get; set; }
        [XmlAttribute("slit_left")] public double SplitLeft { get; set; }
        [XmlAttribute("type_outside")] public string TypeOutside { get; set; }
        [XmlAttribute("isPress")] public string IsPress { get; set; }
    }

    public class Footing : MemberBase
    {
    }

    public class StripFooting : MemberBase
    {
    }

    public class Pile : MemberBase
    {
    }

    public class FoundationColumn : MemberBase
    {
    }

    public class Parapet : MemberBase
    {
    }

    public class Open : MemberBase
    {
        [XmlAttribute("position_X")] public double PositionX { get; set; }
        [XmlAttribute("position_Y")] public double PositionY { get; set; }
        [XmlAttribute("length_X")] public double LengthX { get; set; }
        [XmlAttribute("length_Y")] public double LengthY { get; set; }
        [XmlAttribute("rotate")] public double Rotate { get; set; }
    }
}