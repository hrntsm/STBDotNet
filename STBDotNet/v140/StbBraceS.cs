using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbSecBraceS : StbSectionBase, ISecBrace
    {
        [XmlAttribute("kind_brace")] public string KindBeam { get; set; }
        // child element
        [XmlElement("StbSecSteelBrace")] public SecSteel[] SteelBrace { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} {Name}, Type:StbSecBeamS, StbSection:{SteelBrace[0].Shape}";
        }
    }
}