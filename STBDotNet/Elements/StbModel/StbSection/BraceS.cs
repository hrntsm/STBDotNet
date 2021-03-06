using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class BraceS : SectionBase, ISecBrace
    {
        [XmlAttribute("kind_brace")] public string KindBeam { get; set; }
        // child element
        [XmlElement("StbSecSteelBrace")] public SecSteel[] SteelBrace { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} {Name}, Type:BeamS, Section:{SteelBrace[0].Shape}";
        }
    }
}