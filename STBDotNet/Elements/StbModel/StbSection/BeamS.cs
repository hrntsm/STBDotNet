using System.Xml.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public class BeamS : SectionBase, ISecBeam, IJointId
    {
        [XmlAttribute("kind_beam")] public string KindBeam { get; set; }
        [XmlAttribute("isCanti")]  public string IsCanti { get; set; }
        [XmlAttribute("isOutIn")]  public string IsOutIn { get; set; }
        [XmlAttribute("joint_id_start")] public int JointIdStart { get; set; }
        [XmlAttribute("joint_id_end")] public int JointIdEnd { get; set; }
        // child element
        [XmlElement("StbSecSteelBeam")] public SecSteelBeam[] SteelBeams { get; set; }
    }

    public class SecSteelBeam
    {
        [XmlAttribute("pos")]public string Position { get; set; }
        [XmlAttribute("shape")]public string Shape { get; set; }
        [XmlAttribute("strength_main")]public string StrengthMain { get; set; }
        [XmlAttribute("strength_web")]public string StrengthWeb { get; set; }
    }
 }
