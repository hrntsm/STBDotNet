using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140.StbModel.StbSection
{
    public class StbSteel : Section
    {
        [XmlElement("StbSecRoll-H")] public List<RollH> RollH { get; set; }
        [XmlElement("StbSecBuild-H")] public List<BuildH> BuildH { get; set; }
        [XmlElement("StbSecRoll-BOX")] public List<RollBox> RollBox { get; set; }
        [XmlElement("StbSecBuild-BOX")] public List<BuildBox> BuildBox { get; set; }
        [XmlElement("StbSecPipe")] public List<Pipe> Pipe { get; set; }
        [XmlElement("StbSecRoll-T")] public List<RollT> RollT { get; set; }
        [XmlElement("StbSecRoll-C")] public List<RollC> RollC { get; set; }
        [XmlElement("StbSecRoll-L")] public List<RollL> RollL { get; set; }
        [XmlElement("StbSecRoll-LipC")] public List<LipC> LipC { get; set; }
        [XmlElement("StbSecRoll-FB")] public List<FlatBar> FlatBar { get; set; }
        [XmlElement("StbSecRoll-Bar")] public List<RoundBar> RoundBar { get; set; }

        public override string ToString()
        {
            int numSection
                = RollH?.Count ?? 0
                + BuildH?.Count ?? 0
                + RollBox?.Count ?? 0
                + BuildBox?.Count ?? 0
                + Pipe?.Count ?? 0
                + RollT?.Count ?? 0
                + RollC?.Count ?? 0
                + RollL?.Count ?? 0
                + LipC?.Count ?? 0
                + FlatBar?.Count ?? 0
                + RoundBar?.Count ?? 0;
            return $"Number of Steel Sections:{numSection}";
        }
    }

    public abstract class SteelSectionBase
    {
        [XmlAttribute("name")] public string Name { get; set; }
    }

    public abstract class WidthHeightSection : SteelSectionBase
    {
        [XmlAttribute("A")] public double A { get; set; }
        [XmlAttribute("B")] public double B { get; set; }
    }

    public abstract class HShapeBase : WidthHeightSection
    {
        [XmlAttribute("t1")] public double T1 { get; set; }
        [XmlAttribute("t2")] public double T2 { get; set; }
    }

    public abstract class CLShapeBase : HShapeBase, ISideType
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("r1")] public double R1 { get; set; }
        [XmlAttribute("r2")] public double R2 { get; set; }
        [XmlAttribute("side")] public string Side { get; set; }
    }

    public abstract class BoxShapeBase : WidthHeightSection
    { }

    public interface ISideType
    {
        string Side { get; set; }
    }

    public class RollH : HShapeBase
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("r")] public double R { get; set; }
    }

    public class BuildH : HShapeBase
    { }

    public class RollBox : BoxShapeBase
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
        [XmlAttribute("R")] public double R { get; set; }
    }

    public class BuildBox : BoxShapeBase
    {
        [XmlAttribute("t1")] public double T1 { get; set; }
        [XmlAttribute("t2")] public double T2 { get; set; }
    }

    public class Pipe : SteelSectionBase
    {
        [XmlAttribute("D")] public double D { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
    }

    public class RollT : RollH
    { }

    public class RollC : CLShapeBase
    { }

    public class RollL : CLShapeBase
    { }

    public class LipC : SteelSectionBase, ISideType
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("H")] public double H { get; set; }
        [XmlAttribute("B")] public double B { get; set; }
        [XmlAttribute("C")] public double C { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
        [XmlAttribute("side")] public string Side { get; set; }
    }

    public class FlatBar : SteelSectionBase
    {
        [XmlAttribute("B")] public double B { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
    }

    public class RoundBar : SteelSectionBase
    {
        [XmlAttribute("R")] public double R { get; set; }
    }
}