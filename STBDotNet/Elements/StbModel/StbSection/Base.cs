using System.Collections.Generic;
using System.Xml.Serialization;
using STBDotNet.Serialization;

namespace STBDotNet.Elements.StbModel.StbSection
{
    public abstract class SectionBase : Section, IModel, ISection
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        [XmlAttribute("floor")] public string Floor { get; set; }
    }

    public abstract class RcSection : SectionBase, IBarArrangement
    {
        [XmlAttribute("strength_concrete")] public string StrengthConcrete { get; set; }
        [XmlAttribute("D_reinforcement_main")] public string DBarMain { get; set; }
        [XmlAttribute("D_reinforcement_2nd_main")] public string DBar2ndMain { get; set; }
        [XmlAttribute("D_reinforcement_axial")] public string DBarAxial { get; set; }
        [XmlAttribute("D_reinforcement_band")] public string DBarBand { get; set; }
        [XmlAttribute("D_bar_spacing")] public string DBarSpacing { get; set; }
        [XmlAttribute("Strength_reinforcement_main")] public string StrengthBarMain { get; set; }
        [XmlAttribute("Strength_reinforcement_2nd_main")] public string StrengthBar2ndMain { get; set; }
        [XmlAttribute("Strength_reinforcement_axial")] public string StrengthBarAxial { get; set; }
        [XmlAttribute("Strength_reinforcement_band")] public string StrengthBarBand { get; set; }
        [XmlAttribute("Strength_bar_spacing")] public string StrengthBarSpacing { get; set; }
        [XmlAttribute("kind_reinforcement_corner")] public string KindBarCorner { get; set; }
        [XmlAttribute("interval_reinforcement")] public double IntervalBar { get; set; }
        [XmlAttribute("center_reinforcement_start_X")] public double CenterBarStartX { get; set; }
        [XmlAttribute("center_reinforcement_start_Y")] public double CenterBarStartY { get; set; }
        [XmlAttribute("center_reinforcement_end_X")] public double CenterBarEndX { get; set; }
        [XmlAttribute("center_reinforcement_end_Y")] public double CenterBarEndY { get; set; }
    }

    public abstract class SteelSectionBase : Section, IModel, ISteelSection
    {
        [XmlAttribute("id")] public int Id { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
        public ShapeType ShapeType { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public double P6 { get; set; }
    }
}