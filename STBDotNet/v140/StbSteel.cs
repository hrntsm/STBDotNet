using System.Collections.Generic;
using System.Xml.Serialization;

namespace STBDotNet.v140
{
    public class StbSecSteel : StbSection
    {
        [XmlElement("StbSecRoll-H")] public List<StbSeRollH> RollH { get; set; }
        [XmlElement("StbSecBuild-H")] public List<StbSecBuildH> BuildH { get; set; }
        [XmlElement("StbSecRoll-BOX")] public List<StbSecRollBox> RollBox { get; set; }
        [XmlElement("StbSecBuild-BOX")] public List<StbSecBuildBox> BuildBox { get; set; }
        [XmlElement("StbSecPipe")] public List<StbSecPipe> Pipe { get; set; }
        [XmlElement("StbSecRoll-T")] public List<StbSecRollT> RollT { get; set; }
        [XmlElement("StbSecRoll-C")] public List<StbSecRollC> RollC { get; set; }
        [XmlElement("StbSecRoll-L")] public List<StbSecRollL> RollL { get; set; }
        [XmlElement("StbSecRoll-LipC")] public List<StbSecRollLipC> LipC { get; set; }
        [XmlElement("StbSecRoll-FB")] public List<StbSecRollFB> FlatBar { get; set; }
        [XmlElement("StbSecRoll-Bar")] public List<StbSecRollRoundBar> RoundBar { get; set; }

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
            return $"Number of StbSecSteel Sections:{numSection}";
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

    public class StbSeRollH : HShapeBase
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("r")] public double R { get; set; }
    }

    public class StbSecBuildH : HShapeBase
    { }

    public class StbSecRollBox : BoxShapeBase
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
        [XmlAttribute("R")] public double R { get; set; }
    }

    public class StbSecBuildBox : BoxShapeBase
    {
        [XmlAttribute("t1")] public double T1 { get; set; }
        [XmlAttribute("t2")] public double T2 { get; set; }
    }

    public class StbSecPipe : SteelSectionBase
    {
        [XmlAttribute("D")] public double D { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
    }

    public class StbSecRollT : StbSeRollH
    { }

    public class StbSecRollC : CLShapeBase
    { }

    public class StbSecRollL : CLShapeBase
    { }

    public class StbSecRollLipC : SteelSectionBase, ISideType
    {
        [XmlAttribute("type")] public string Type { get; set; }
        [XmlAttribute("H")] public double H { get; set; }
        [XmlAttribute("B")] public double B { get; set; }
        [XmlAttribute("C")] public double C { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
        [XmlAttribute("side")] public string Side { get; set; }
    }

    public class StbSecRollFB : SteelSectionBase
    {
        [XmlAttribute("B")] public double B { get; set; }
        [XmlAttribute("t")] public double T { get; set; }
    }

    public class StbSecRollRoundBar : SteelSectionBase
    {
        [XmlAttribute("R")] public double R { get; set; }
    }
}