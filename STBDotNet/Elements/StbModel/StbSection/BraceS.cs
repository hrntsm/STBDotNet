using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class BraceS : SectionBase, ISecBrace
    {
        [XmlAttribute("kind_brace")] public string KindBeam { get; set; }
        // child element
        [XmlElement("StbSecSteelBrace")] public SecSteelBrace[] SteelBrace { get; set; }
    }

    public class SecSteelBrace : SecSteelBeam
    { }
}