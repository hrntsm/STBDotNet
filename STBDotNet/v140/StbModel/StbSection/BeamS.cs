using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel.StbSection
{
    public class BeamS : SectionBase, ISecBeam, IJointId
    {
        [XmlAttribute("kind_beam")] public string KindBeam { get; set; }
        [XmlAttribute("isCanti")] public string IsCanti { get; set; }
        [XmlAttribute("isOutIn")] public string IsOutIn { get; set; }
        [XmlAttribute("joint_id_start")] [DefaultValue(0)] public int JointIdStart { get; set; }
        [XmlAttribute("joint_id_end")] [DefaultValue(0)] public int JointIdEnd { get; set; }
        // child element
        [XmlElement("StbSecSteelBeam")] public SecSteel[] SteelBeams { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} {Name}, Type:BeamS, Section:{SteelBeams[0].Shape}";
        }
    }
}
