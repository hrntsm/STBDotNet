using System.ComponentModel;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public abstract class StbSection
    { }

    public abstract class StbSectionBase : StbSection, IModel, ISection
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("floor")] public string Floor { get; set; }
    }

    public abstract class RcSection : StbSectionBase
    {
        [XmlAttribute("strength_concrete")] public string StrengthConcrete { get; set; }
        [XmlAttribute("D_reinforcement_main")] public string DBarMain { get; set; }
        [XmlAttribute("D_reinforcement_2nd_main")] public string DBar2ndMain { get; set; }
        [XmlAttribute("D_bar_spacing")] public string DBarSpacing { get; set; }
        [XmlAttribute("strength_reinforcement_main")] public string StrengthBarMain { get; set; }
        [XmlAttribute("strength_reinforcement_2nd_main")] public string StrengthBar2ndMain { get; set; }
        [XmlAttribute("strength_bar_spacing")] public string StrengthBarSpacing { get; set; }
        [XmlAttribute("interval_reinforcement")] [DefaultValue(0d)] public double IntervalBar { get; set; }
    }
}
