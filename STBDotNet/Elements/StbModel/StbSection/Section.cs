using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class ColumnS : SectionBase
    {
        [XmlAttribute("kind_column")] public string KindColumn { get; set; }
        [XmlAttribute("direction")] public string Direction { get; set; }
        [XmlAttribute("base_type")] public string BaseType { get; set; }
        [XmlAttribute("joint_id_bottom")] public int JointIdStart { get; set; }
        [XmlAttribute("joint_id_top")] public int JointIdEnd { get; set; }
        [XmlElement("StbSecSteelColumn")] public SecSteelColumn[] SecSteelColumn { get; set; }
        [XmlElement("StbSecBaseProduct")] public BaseProduct BaseProduct { get; set; }
    }
    public class SecSteelColumn
    {
        [XmlAttribute("pos")]public string Position { get; set; }
        [XmlAttribute("shape")]public string Shape { get; set; }
        [XmlAttribute("strength_main")]public string StrengthMain { get; set; }
        [XmlAttribute("strength_web")]public string StrengthWeb { get; set; }
    }

    public class BaseProduct
    {
        [XmlAttribute("product_company")] public string Company { get; set; }
        [XmlAttribute("product_code")] public string Code { get; set; }
    }

    public class ColumnSrc : Section
    {
    }

    public class ColumnCft : Section
    {
    }

    public class BeamRc : Section
    {
    }

    public class BeamS : Section
    {
    }

    public class BeamSrc : Section
    {
    }

    public class BraceS : Section
    {
    }

    public class SlabRc : Section
    {
    }

    public class SlabDeck : Section
    {
    }

    public class WallRc : Section
    {
    }

    public class FoundationRc : Section
    {
    }

    public class PileRc : Section
    {
    }

    public class OpenRc : Section
    {
    }
}