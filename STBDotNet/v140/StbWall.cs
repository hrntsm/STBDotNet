using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel.StbSection
{
    public class WallRc : Section, IModel
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("depth")] public double Depth { get; set; }
        [XmlAttribute("strength_concrete")] public string StrengthConcrete { get; set; }
        [XmlAttribute("depth_cover_outside")] [DefaultValue(0d)] public double DepthCoverOutside { get; set; }
        [XmlAttribute("depth_cover_inside")] [DefaultValue(0d)] public double DepthCoverInside { get; set; }
        // child element
        [XmlElement("StbSecBar_Arrangement")] public WallSecBarArrangement BarArrangement { get; set; }
    }

    public class WallSecBarArrangement
    {
        [XmlElement("StbSecSingle")] public Single[] SingleWall { get; set; }
        [XmlElement("StbSecZigzag")] public Zigzag[] ZigzagWall { get; set; }
        [XmlElement("StbSecDouble_Net")] public DoubleNet[] DoubleNetWall { get; set; }
        [XmlElement("StbSecInside_And_Outside")] public InsideAndOutSide[] InsideAndOutSideWall { get; set; }
        [XmlElement("StbSecWallEdge")] public Edge[] EdgeWall { get; set; }
        [XmlElement("StbSecOpen_Wall")] public OpenBar[] OpenWall { get; set; }

        public class Base
        {
            [XmlAttribute("pos")] public string Position { get; set; }
            [XmlAttribute("strength")] public string Strength { get; set; }
            [XmlAttribute("D")] public string D { get; set; }
        }

        public class Single : Base
        {
            [XmlAttribute("pitch")] public double Pitch { get; set; }
        }

        public class Zigzag : Single
        { }

        public class DoubleNet : Single
        { }

        public class InsideAndOutSide : Single
        {
            [XmlAttribute("pos2")] public string Position2 { get; set; }
        }

        public class Edge : Base
        {
            [XmlAttribute("count")] public int Count { get; set; }
        }

        public class OpenBar : Edge
        {
            [XmlAttribute("length")] public double Length { get; set; }
        }
    }
}