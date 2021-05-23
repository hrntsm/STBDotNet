using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel.StbSection
{
    public class ColumnS : SectionBase, ISecColumn, IJointId
    {
        [XmlAttribute("kind_column")] public string KindColumn { get; set; }
        [XmlAttribute("direction")] public string Direction { get; set; }
        [XmlAttribute("base_type")] public string BaseType { get; set; }
        [XmlAttribute("joint_id_bottom")] [DefaultValue(0)] public int JointIdStart { get; set; }
        [XmlAttribute("joint_id_top")] [DefaultValue(0)] public int JointIdEnd { get; set; }
        [XmlElement("StbSecSteelColumn")] public SecSteel[] SteelColumn { get; set; }
        [XmlElement("StbSecBaseProduct")] public BaseProduct BaseProduct { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} {Name}, Type:ColS, Section:{SteelColumn[0].Shape}";
        }
    }

    public class SecSteel
    {
        [XmlAttribute("pos")] public string Position { get; set; }
        [XmlAttribute("shape")] public string Shape { get; set; }
        [XmlAttribute("strength_main")] public string StrengthMain { get; set; }
        [XmlAttribute("strength_web")] public string StrengthWeb { get; set; }
    }

    public class BaseProduct
    {
        [XmlAttribute("product_company")] public string Company { get; set; }
        [XmlAttribute("product_code")] public string Code { get; set; }
    }
}