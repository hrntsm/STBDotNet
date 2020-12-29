using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public abstract class Section
    { }

    public abstract class SectionBase : Section, IModel, ISection
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("floor")] public string Floor { get; set; }
    }

    public abstract class RcSection : SectionBase
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