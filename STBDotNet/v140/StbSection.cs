using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbSecColumnSrc : StbSectionBase
    { }

    public class StbSecColumnCft : StbSectionBase
    { }

    public class StbSecBeamSrc : StbSectionBase, ISecBeam
    {
        [XmlAttribute("kind_beam")] public string KindBeam { get; set; }
        [XmlAttribute("isCanti")] public string IsCanti { get; set; }
        [XmlAttribute("isOutIn")] public string IsOutIn { get; set; }
    }

    public class StbSecFoundationRc : StbSection
    { }

    public class StbSecPileRc : StbSection
    { }

    public class StbSecOpenRc : StbSection
    { }
}