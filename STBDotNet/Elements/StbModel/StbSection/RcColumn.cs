using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class ColumnRc : RcSection
    {
        [XmlAttribute("kind_column")] public string KindColumn { get; set; }
        [XmlAttribute("depth_cover_start_X")] public double DepthCoverStartX { get; set; }
        [XmlAttribute("depth_cover_end_X")] public double DepthCoverEndX { get; set; }
        [XmlAttribute("depth_cover_start_Y")] public double DepthCoverStartY { get; set; }
        [XmlAttribute("depth_cover_end_Y")] public double DepthCoverEndY { get; set; }
        [XmlElement("StbSecFigure")] public SecRcFigure Figure { get; set; }
        [XmlElement("StbSecBar_Arrangement")] public BarArrange BarArrange { get; set; }
    }

    public class SecRcFigure
    {
        [XmlElement("StbSecRect")] public Rectangle SecRect { get; set; }
        [XmlElement("StbSecCircle")] public Circle SecCircle { get; set; }

        public class Rectangle
        {
            [XmlAttribute("DX")] public double DX { get; set; }
            [XmlAttribute("DY")] public double DY { get; set; }
        }

        public class Circle
        {
            [XmlAttribute("D")] public double DX { get; set; }
            public double DY => -1;
        }
    }

    public class BarArrange
    {
    }
}