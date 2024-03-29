using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbMembers
    {
        [XmlArray("StbColumns")]
        [XmlArrayItem("StbColumn")] public List<StbColumn> Columns { get; set; }
        [XmlArray("StbPosts")]
        [XmlArrayItem("StbPost")] public List<StbPost> Posts { get; set; }
        [XmlArray("StbGirders")]
        [XmlArrayItem("StbGirder")] public List<StbGirder> Girders { get; set; }
        [XmlArray("StbBeams")]
        [XmlArrayItem("StbBeam")] public List<StbBeam> Beams { get; set; }
        [XmlArray("StbBraces")]
        [XmlArrayItem("StbBrace")] public List<StbBrace> Braces { get; set; }
        [XmlArray("StbSlabs")]
        [XmlArrayItem("StbSlab")] public List<StbSlab> Slabs { get; set; }
        [XmlArray("StbWalls")]
        [XmlArrayItem("StbWall")] public List<StbWall> Walls { get; set; }
        [XmlArray("StbFootings")]
        [XmlArrayItem("StbFooting")] public List<StbFooting> Footings { get; set; }
        [XmlArray("StbStrip_Footings")]
        [XmlArrayItem("StbStrip_Footing")] public List<StbStripFooting> StripFootings { get; set; }
        [XmlArray("StbPiles")]
        [XmlArrayItem("StbPile")] public List<StbPile> Piles { get; set; }
        [XmlArray("StbFoundationColumns")]
        [XmlArrayItem("StbFoundationColumn")] public List<StbFoundationColumn> FoundationColumns { get; set; }
        [XmlArray("StbParapets")]
        [XmlArrayItem("StbParapet")] public List<StbParapet> Parapets { get; set; }

        public override string ToString()
        {
            int numColumn = Columns?.Count ?? 0;
            int numPost = Posts?.Count ?? 0;
            int numGirder = Girders?.Count ?? 0;
            int numBeam = Beams?.Count ?? 0;
            int numBrace = Braces?.Count ?? 0;
            int numSlab = Slabs?.Count ?? 0;
            int numWall = Walls?.Count ?? 0;
            int numFooting = Footings?.Count ?? 0;
            int numSFooting = StripFootings?.Count ?? 0;
            int numPile = Piles?.Count ?? 0;
            int numFColumn = FoundationColumns?.Count ?? 0;
            int numParapet = Parapets?.Count ?? 0;

            var sb = new StringBuilder();
            sb.Append($"Column:{numColumn}, Post:{numPost}, Girder:{numGirder}, Beam:{numBeam}, Brace:{numBrace}\n");
            sb.Append($"Slab:{numSlab}, Wall:{numWall}\n");
            sb.Append($"Footing:{numFooting}, StripFooting:{numSFooting}, Pile:{numPile}, FoundationColumn:{numFColumn}, Parapet:{numParapet}");
            return sb.ToString();
        }
    }

    public class FrameBase : StbMemberBase, IFrame
    {
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

    public class StbColumn : FrameBase, IFrameIdNode
    {
        [XmlAttribute("idNode_bottom")] public int IdNodeStart { get; set; }
        [XmlAttribute("idNode_top")] public int IdNodeEnd { get; set; }
        [XmlAttribute("offset_X")] [DefaultValue(0d)] public double OffsetX { get; set; }
        [XmlAttribute("offset_Y")] [DefaultValue(0d)] public double OffsetY { get; set; }
        [XmlAttribute("thickness_ex_start_X")] [DefaultValue(0d)] public double ThicknessExStartX { get; set; }
        [XmlAttribute("thickness_ex_start_Y")] [DefaultValue(0d)] public double ThicknessExStartY { get; set; }
        [XmlAttribute("thickness_ex_end_X")] [DefaultValue(0d)] public double ThicknessExEndX { get; set; }
        [XmlAttribute("thickness_ex_end_Y")] [DefaultValue(0d)] public double ThicknessExEndY { get; set; }
    }

    public class StbPost : StbColumn
    { }

    public class StbGirder : FrameBase, IFrameIdNode
    {
        [XmlAttribute("idNode_start")] public int IdNodeStart { get; set; }
        [XmlAttribute("idNode_end")] public int IdNodeEnd { get; set; }
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

    public class StbBeam : StbGirder
    { }

    public class StbBrace : FrameBase, IFrameIdNode
    {
        [XmlAttribute("idNode_start")] public int IdNodeStart { get; set; }
        [XmlAttribute("idNode_end")] public int IdNodeEnd { get; set; }
        [XmlAttribute("future_brace")] public string FutureBrace { get; set; }
    }

    public class StbSlab : PlateBase
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

    public class StbWall : PlateBase
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

    public class StbFooting : StbMemberBase
    {
    }

    public class StbStripFooting : StbMemberBase
    {
    }

    public class StbPile : StbMemberBase
    {
    }

    public class StbFoundationColumn : StbMemberBase
    {
    }

    public class StbParapet : StbMemberBase
    {
    }

    public class Open : StbMemberBase
    {
        [XmlAttribute("position_X")] public double PositionX { get; set; }
        [XmlAttribute("position_Y")] public double PositionY { get; set; }
        [XmlAttribute("length_X")] public double LengthX { get; set; }
        [XmlAttribute("length_Y")] public double LengthY { get; set; }
        [XmlAttribute("rotate")] public double Rotate { get; set; }
    }
}