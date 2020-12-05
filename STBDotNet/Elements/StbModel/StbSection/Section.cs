using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class ColumnSrc : SectionBase
    { }

    public class ColumnCft : SectionBase
    { }

    public class BeamSrc : SectionBase, ISecBeam
    {
        [XmlAttribute("kind_beam")] public string KindBeam { get; set; }
        [XmlAttribute("isCanti")] public string IsCanti { get; set; }
        [XmlAttribute("isOutIn")] public string IsOutIn { get; set; }
    }

    public class SlabRc : Section
    { }

    public class SlabDeck : Section
    { }

    public class WallRc : Section
    { }

    public class FoundationRc : Section
    { }

    public class PileRc : Section
    { }

    public class OpenRc : Section
    { }
}